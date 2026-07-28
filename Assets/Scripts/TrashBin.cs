using UnityEngine;

public class TrashBin : MonoBehaviour
{
    public LevelManager levelManager;

    void Start()
    {
        // Si no está asignado desde el Inspector, lo busca en la escena
        if (levelManager == null)
        {
            levelManager = FindObjectOfType<LevelManager>();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Insulto"))
        {
            Debug.Log("¡Basura encestada! Subiendo barra...");

            if (levelManager != null)
            {
                levelManager.AddPoint();
            }
            else
            {
                Debug.LogError("¡ATENCIÓN: TrashBin no encuentra el LevelManager!");
            }

            Destroy(other.gameObject);
        }
    }
}