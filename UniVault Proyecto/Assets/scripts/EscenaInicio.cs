using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaInicio : MonoBehaviour
{
    public void Entrar()
    {
        SceneManager.LoadScene("UniVaultMain"); 
    }

    public void VolverAlInicio()
    {
        SceneManager.LoadScene("Inicio"); 
    }

}
