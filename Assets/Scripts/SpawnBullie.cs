using UnityEngine;

public class SpawnBullie : MonoBehaviour
{
    [SerializeField] GameObject bulliePrefab;
    [SerializeField] Collider2D colisionarEnemigo;
    [SerializeField] Transform spawnPoint;
    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D ColliderJugador)
    {
        if (ColliderJugador.CompareTag("Player"))
        {
            Instantiate(bulliePrefab,spawnPoint.position,spawnPoint.rotation);
            colisionarEnemigo.enabled = false;
            Debug.Log("colisiono!");
        }
    }
   
}
