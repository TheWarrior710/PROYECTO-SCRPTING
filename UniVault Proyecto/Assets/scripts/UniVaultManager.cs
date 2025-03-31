using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class UniVaultManager : MonoBehaviour
{
    public TMP_InputField pinInput;
    public GameObject mainMenu;
    public GameObject pinScreen;
    private string correctPin = "1234";

    public TextMeshProUGUI notesText;
    public TMP_InputField notesInput;

    private string notesFilePath;

    void Start()
    {
        notesFilePath = Path.Combine(Application.persistentDataPath, "notes.txt");
        LoadNotes();
    }

    public void CheckPin()
    {
        if (pinInput.text == correctPin)
        {
            pinScreen.SetActive(false);
            mainMenu.SetActive(true);
        }
        else
        {
            Debug.Log("PIN incorrecto");
        }
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
}
