using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ArchivoBuscador : MonoBehaviour
{
    public TMP_InputField searchField;
    public Transform fileListParent;

    private List<GameObject> allFileItems = new List<GameObject>();

    public void RegistrarBoton(GameObject boton)
    {
        allFileItems.Add(boton);
    }

    public void LimpiarLista()
    {
        allFileItems.Clear();
    }

    public void Buscar()
    {
        string searchText = searchField.text.ToLower();

        foreach (GameObject fileItem in allFileItems)
        {
            if (fileItem.name.ToLower().Contains(searchText))
            {
                fileItem.SetActive(true);
            }
            else
            {
                fileItem.SetActive(false);
            }
        }
    }
}
