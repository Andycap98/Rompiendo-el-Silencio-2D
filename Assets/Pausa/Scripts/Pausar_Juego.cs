using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausar_Juego : MonoBehaviour
{

    public GameObject menuPausa;
    public bool juegoPausado = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        { 
            if (juegoPausado)

            {
                Reanudar();
            }
            else
            {
                Pausar();
            }
        }


    }
    public void Reanudar()
    {
        menuPausa.SetActive(false);
        Time.timeScale = 1f;
        juegoPausado = false;
    }
    public void Pausar()
    {
        menuPausa.SetActive(true);
        Time.timeScale = 0f;
        juegoPausado = true;
    }
    public void Restart()
    {
        Time.timeScale = 1f;
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Salir()
    {
        Debug.Log("Salir del juego");
        Application.Quit();
    }
}
