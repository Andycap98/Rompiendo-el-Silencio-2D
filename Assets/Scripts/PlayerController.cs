using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private float horizontalInput;
    private float verticalInput;
    private Vector2 direccionMovement;
    void Start()
    {
        
    }

    // normalizar vector para poder incremetar la velocidad del player en diagonal
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        direccionMovement = new Vector2(horizontalInput, verticalInput);
        if (direccionMovement.magnitude>1)
                       direccionMovement=direccionMovement.normalized;//normaliza el vector cuando toca la tecla incremente
        PersonajeMovimiento();
    }

    void PersonajeMovimiento()
    { 
      Vector3 movimiento = new Vector3(direccionMovement.x, direccionMovement.y,0) * speed * Time.deltaTime;
      transform.Translate(movimiento, Space.World);


    }
}
   
