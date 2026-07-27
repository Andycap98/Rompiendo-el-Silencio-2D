using UnityEngine;

public class PaperSpawner : MonoBehaviour
{
    [Header("Configuración del Spawner")]
    public GameObject papelPrefab;
    public float tiempoEntreSpawns = 2f;

    // Opcional: Para que no todos los spawners disparen al mismo tiempo exacto
    public float tiempoInicio = 1f;

    void Start()
    {
        // Empieza a spawnear después de 'tiempoInicio' y luego cada 'tiempoEntreSpawns'
        InvokeRepeating(nameof(SpawnPapel), tiempoInicio, tiempoEntreSpawns);
    }

    void SpawnPapel()
    {
        // Instancia el papel exactamente en la posición de ESTE objeto
        Instantiate(papelPrefab, transform.position, Quaternion.identity);
    }
}