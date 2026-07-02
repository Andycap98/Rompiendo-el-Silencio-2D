using UnityEngine;

public class MovimientoBullies : MonoBehaviour
{
    public float velocidad = 5f;
    public float amplitud = 2f;
    public float frecuencia = 2f;
    private Vector3 posicionInicial;
    private float tiempo ;
   //LA POSICION INICIAL SEA IGUAL A LA POSICION QUE LE VAMOS A PONER
    void Start()
    {
        posicionInicial = transform.position;// haciendo ref al comp transform y a la pos inicial y la guarde
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        float x = transform.position.x - velocidad * Time.deltaTime;// va a ser q la pos x se vaya reduciendo y lo multiplicamos deltatime
        float y = posicionInicial.y + Mathf.Sin(tiempo * frecuencia) * amplitud; //movimiento senosuidal (math.sin)= devuelve un valor entre 1 <1
        transform.position = new Vector3(x, y, transform.position.z);// poner los valores x e y para poner en el objeto
    }
}
