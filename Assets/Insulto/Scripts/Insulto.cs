using UnityEngine;

public class Insulto : MonoBehaviour
{
    public float velocidad = 6f;
    public float tiempoVida = 3f;
    public float daño = 5f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.linearVelocity = Vector2.left * velocidad;

        Destroy(gameObject, tiempoVida);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Aquí puedes llamar al script de vida del jugador

            Destroy(gameObject);
        }
    }
}
