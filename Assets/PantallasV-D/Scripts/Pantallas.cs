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
        Debug.Log("Salir del juego");
        Application.Quit();
    }
    public void SiguienteNivel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Nivel_2");
    }
    public void ReintentarNivel2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Nivel_2");
    }
}
