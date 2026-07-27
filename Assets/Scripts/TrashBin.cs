using UnityEngine;

public class TrashBin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Insulto"))
        {
            Debug.Log("¡Basura encestada! Subiendo barra...");

            Destroy(other.gameObject);
        }
    }
}