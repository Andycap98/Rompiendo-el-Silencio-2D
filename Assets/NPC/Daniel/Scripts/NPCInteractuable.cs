using UnityEngine;

public class NPCInteractuable : MonoBehaviour
{
    public GameObject panelDialogo;

    private bool jugadorCerca = false;

    private bool yaHablo = false;

    void Update()
    {
        if (yaHablo)
            return;

        if (jugadorCerca && Input.GetKeyDown(KeyCode.E))
        {
            panelDialogo.SetActive(true);
            Time.timeScale = 0f;
        }
        if (jugadorCerca && Input.GetKeyDown(KeyCode.E))
        {
            panelDialogo.SetActive(true);

            Time.timeScale = 0f; // Pausa el juego
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            jugadorCerca = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            jugadorCerca = false;

            panelDialogo.SetActive(false);

            Time.timeScale = 1f;
        }
    }
    public void MarcarComoHablado()
    {
        yaHablo = true;
    }
}
