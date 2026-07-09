using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    public Animator animator;
    private float horizontalInput;
    private float verticalInput;
    private Vector2 direccionMovement;
    public int autoestima = 100;
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

          animator.SetFloat("movement", direccionMovement.magnitude);
          animator.SetFloat("horizontal", horizontalInput);
          animator.SetFloat("Vertical", verticalInput);
        if (horizontalInput > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (horizontalInput < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        PersonajeMovimiento();
    }

    void PersonajeMovimiento()
    { 
      Vector3 movimiento = new Vector3(direccionMovement.x, direccionMovement.y,0) * speed * Time.deltaTime;
      transform.Translate(movimiento, Space.World);


    }

    public void  RestarAutoestima() {
        Debug.Log("Restamos Autoestima al player");
    }
}
   
