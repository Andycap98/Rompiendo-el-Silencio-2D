using UnityEngine;

public class SeguimientoDeCamara : MonoBehaviour
{
    [SerializeField] private Transform objetivo;
    [SerializeField] private float suavizado = 5;
    [SerializeField] private Vector2 offset;
    private float zoriginal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        zoriginal = transform.position.z;// guardamos la posicion 

    }

    // el metodo mas especifico para la camara
    void LateUpdate()
    {
        if (objetivo == null) return;
        Vector2 posicionDeseada = (Vector2)objetivo.position + offset;// calcula la posicion ideal en 2d (decirle a la camara a donde ir) 
        Vector2 posicionSuavizada = Vector2.Lerp((Vector2)transform.position, posicionDeseada,suavizado*Time.deltaTime);
        transform.position = new Vector3(posicionSuavizada.x, posicionSuavizada.y, zoriginal);

    }
}
