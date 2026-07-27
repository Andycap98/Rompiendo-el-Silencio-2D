using UnityEngine;

public class Insulto : MonoBehaviour
{
    public float velocidad = 6f;
    public float tiempoVida = 3f;
    public int daño = 1;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.linearVelocity = Vector2.left * velocidad;

        Destroy(gameObject, tiempoVida);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();

            if (player != null)
            {
                player.RestarAutoestima(daño);
            }

            Destroy(gameObject);
        }
    }
}