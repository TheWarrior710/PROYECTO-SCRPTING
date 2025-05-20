using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class UniVaultManager : MonoBehaviour
{
    public Transform fileListParent;

    public GameObject mainMenu;
    public GameObject reminderPanel;
    public GameObject fileItemPrefab; 


    public TextMeshProUGUI notesText;
    public TMP_InputField notesInput;

    private string notesFilePath;
    private string filesFolderPath;

    void Start()
    {

        filesFolderPath = Path.Combine(Application.persistentDataPath, "Archivos");
        Directory.CreateDirectory(filesFolderPath);
        LoadFiles();

        notesFilePath = Path.Combine(Application.persistentDataPath, "notes.txt");
        mainMenu.SetActive(true);
        LoadNotes();
        InvokeRepeating("ShowReminder", 30f, 60f); 
    }

  

    public void AddFile()
    {
#if UNITY_EDITOR
        string path = UnityEditor.EditorUtility.OpenFilePanel("Seleccionar archivo", "", "*");
        if (!string.IsNullOrEmpty(path))
        {
            string destPath = Path.Combine(filesFolderPath, Path.GetFileName(path));
            File.Copy(path, destPath, true);
            LoadFiles();
        }
#endif
    }

    void LoadFiles()
    {
        foreach (Transform child in fileListParent)
            Destroy(child.gameObject);

        string[] files = Directory.GetFiles(filesFolderPath);
        foreach (string filePath in files)
        {
            GameObject fileItem = Instantiate(fileItemPrefab, fileListParent);
            FileButton fileButton = fileItem.GetComponent<FileButton>();
            fileButton.SetFile(filePath);


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


    

    void ShowReminder()
    {
        reminderPanel.SetActive(true);
    }

    public void CloseReminder()
    {
        reminderPanel.SetActive(false);
    }




}
