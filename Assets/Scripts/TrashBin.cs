using UnityEngine;

public class TrashBin : MonoBehaviour
{
    [SerializeField] private LevelManager levelManager;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Insulto"))
        {
            Debug.Log("¡Basura encestada! Subiendo barra...");

            // Suma punto en el manager
            if (levelManager != null)
            {
                levelManager.AddPoint();
            }

            Destroy(other.gameObject);
        }
    }
}