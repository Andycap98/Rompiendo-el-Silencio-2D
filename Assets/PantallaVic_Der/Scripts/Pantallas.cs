using UnityEngine;
using UnityEngine.SceneManagement;

public class Pantallas : MonoBehaviour
{
    public void Reintentar()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }

    public void MenuPrincipal()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu_Principal");
    }

    public void Salir()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }
    public void Continuar()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Nivel_2");
    }
}
