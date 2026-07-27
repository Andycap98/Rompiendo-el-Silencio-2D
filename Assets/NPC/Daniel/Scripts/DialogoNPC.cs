using UnityEngine;

public class DialogoNPC : MonoBehaviour
{
    private PlayerController player;

    public Animator npcAnimator;

    public NPCInteractuable npc;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player")
                           .GetComponent<PlayerController>();
    }

    public void RespuestaPositiva()
    {
        player.AumentarAutoestima(1);

        npcAnimator.SetBool("Happy", true);

        npc.MarcarComoHablado();

        CerrarDialogo();
    }

    public void RespuestaNegativa()
    {
        player.RestarAutoestima(3);

        npcAnimator.SetBool("Happy", false);

        npc.MarcarComoHablado();

        CerrarDialogo();
    }

    void CerrarDialogo()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }
}