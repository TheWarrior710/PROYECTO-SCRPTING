using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class UniVaultManager : MonoBehaviour
{
    
    public GameObject mainMenu;
    public GameObject reminderPanel;


    public TextMeshProUGUI notesText;
    public TMP_InputField notesInput;

    private string notesFilePath;

    void Start()
    {
        notesFilePath = Path.Combine(Application.persistentDataPath, "notes.txt");
        mainMenu.SetActive(true);
        LoadNotes();
        InvokeRepeating("ShowReminder", 30f, 60f); 
    }



    public void SaveNotes()
    {
        File.WriteAllText(notesFilePath, notesInput.text);
        LoadNotes();
    }

    public void LoadNotes()
    {
        if (File.Exists(notesFilePath))
        {
            notesText.text = File.ReadAllText(notesFilePath);
        }
    }


    

    void ShowReminder()
    {
        reminderPanel.SetActive(true);
    }

    public void CloseReminder()
    {
        reminderPanel.SetActive(false);
    }

}
