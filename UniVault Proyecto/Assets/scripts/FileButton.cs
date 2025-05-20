using UnityEngine;
using TMPro;
using System.Diagnostics;
using System.IO;
using UnityEngine.UI;

public class FileButton : MonoBehaviour
{
    public TextMeshProUGUI fileNameText;
    public Button deleteButton;

    private string fullPath;

    public void SetFile(string path)
    {
        fullPath = path;
        fileNameText.text = Path.GetFileName(path);

        GetComponent<Button>().onClick.RemoveAllListeners();
        deleteButton.onClick.RemoveAllListeners();

        GetComponent<Button>().onClick.AddListener(OpenFile);
        deleteButton.onClick.AddListener(DeleteFile);
    }

    void OpenFile()
    {
        if (File.Exists(fullPath))
        {
            Process.Start(new ProcessStartInfo(fullPath) { UseShellExecute = true });
        }
    }

    void DeleteFile()
    {
        if (File.Exists(fullPath))
        {
            File.Delete(fullPath);
        }

        Destroy(gameObject);
    }
}

