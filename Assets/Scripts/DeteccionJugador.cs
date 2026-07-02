using UnityEngine;

public class DeteccionJugador : MonoBehaviour
{
    public Transform jugador;
    public float RangoDeAtaque = 2f;
    public float DañoPorSegundo = 5f;
    public float anguloDeVision = 90f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (jugador == null) return;// va a hacer q si no tiene transform (NULL) no se ejecuta la part de abajo

        Vector2 distanciaEntreBullieyJugador = jugador.position - transform.position;
        float Distancia = distanciaEntreBullieyJugador.magnitude;

        if (Distancia > RangoDeAtaque) return;// si esta fuera del rango de ataque no se ejecuta lo de abajo

        Vector2 direccionMirada = Direccion();
        float alineacion = Vector2.Dot(direccionMirada, distanciaEntreBullieyJugador.normalized);
        float limite = Mathf.Cos(anguloDeVision * 0.5f * Mathf.Deg2Rad);

        if (alineacion >= limite)
        {
            // restar vidas jugador
            Debug.Log("Restando vida al jugador: " + (DañoPorSegundo * Time.deltaTime) + " por frame");
        }
    }
    Vector2 Direccion()
    {
        return -transform.right;
    }

    // Dibuja el cono y el rango en la ventana Scene al seleccionar el enemigo
    void OnDrawGizmosSelected()
    {
        Vector2 dir = Direccion();

        // Círculo del rango de ataque (amarillo)
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, RangoDeAtaque);

        // Líneas del cono de visión (rojo)
        Gizmos.color = Color.red;
        float medio = anguloDeVision * 0.5f;

        Vector2 izquierda = Rotar(dir, medio) * RangoDeAtaque;
        Vector2 derecha = Rotar(dir, -medio) * RangoDeAtaque;

        Gizmos.DrawLine(transform.position, (Vector2)transform.position + izquierda);
        Gizmos.DrawLine(transform.position, (Vector2)transform.position + derecha);
    }

    // Rota un vector 2D por un ángulo en grados
    Vector2 Rotar(Vector2 v, float grados)
    {
        float rad = grados * Mathf.Deg2Rad;
        float cos = Mathf.Cos(rad);
        float sin = Mathf.Sin(rad);
        return new Vector2(v.x * cos - v.y * sin, v.x * sin + v.y * cos);
    }
}