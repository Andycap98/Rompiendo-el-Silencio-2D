using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_System : MonoBehaviour
{
    public void jugar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }

    public void salir()
    {
        Debug.Log("Salir del juego...");
        Application.Quit();
    }
}
