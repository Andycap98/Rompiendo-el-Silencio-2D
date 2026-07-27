using UnityEngine;
using UnityEngine.UI;

public class BarraAutoestima : MonoBehaviour
{
    public Image rellenoAutoestima;

    private PlayerController playerController;
    private float autoestimaMaxima;

    void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        autoestimaMaxima = playerController.autoestima;
    }

    void Update()
    {
        rellenoAutoestima.fillAmount = (float)playerController.autoestima / autoestimaMaxima;
    }
}
