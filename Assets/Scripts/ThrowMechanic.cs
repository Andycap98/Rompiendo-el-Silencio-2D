using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ThrowMechanic : MonoBehaviour
{
    [Header("Configuraci�n de Lanzamiento")]
    public float forceMultiplier = 5f;
    public float maxPullDistance = 3f;

    private Rigidbody2D rb;
    private Vector2 startPoint;
    private Vector2 endPoint;
    private bool isDragging = false;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        // ELIMINAMOS rb.isKinematic = true; para que la gravedad act�e apenas nazca
    }

    void OnMouseDown()
    {
        isDragging = true;
        startPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Detenemos el papel en el aire mientras apuntamos
        rb.linearVelocity = Vector2.zero;
        rb.isKinematic = true;
    }

    void OnMouseDrag()
    {
        if (!isDragging) return;

        // Aqu� podr�as actualizar un LineRenderer para mostrar la trayectoria visual
    }

    void OnMouseUp()
    {
        isDragging = false;
        endPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Calculamos el vector de diferencia
        Vector2 forceVector = endPoint - startPoint;

        // Limitamos la magnitud para que el jugador no lance con fuerza infinita
        if (forceVector.magnitude > maxPullDistance)
        {
            forceVector = forceVector.normalized * maxPullDistance;
        }

        Throw(forceVector);
    }

    private void Throw(Vector2 force)
    {
        rb.isKinematic = false; // Activamos la gravedad
        // Aplicamos el impulso f�sico usando la fuerza calculada
        rb.AddForce(force * forceMultiplier, ForceMode2D.Impulse);
    }
}