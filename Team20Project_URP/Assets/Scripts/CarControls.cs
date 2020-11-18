using UnityEngine;

public class CarControls : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 5.0f;// Скорость поворота машины
    [SerializeField] private float throttlePower = 5.0f;// Сила ускорения машины
    //[SerializeField] private float maxSpeed = 10f;// Ограничение максимальной скорости для машины?

    private bool isPlayer1CarDestroyed = false;// Для отключения управления игрока 1 при подрыве на мине
    /// <summary>
    /// Установить в true, чтобы отключить управление игрока 1
    /// </summary>
    public bool IsPlayer1CarDestroyed { get { return isPlayer1CarDestroyed; } set { isPlayer1CarDestroyed = value; } }// Свойство для использования в логике мины

    private bool isPlayer2CarDestroyed = false;// Для отключения управления игрока 2 при подрыве на мине
    /// <summary>
    /// Установить в true, чтобы отключить управление игрока 2
    /// </summary>
    public bool IsPlayer2CarDestroyed { get { return isPlayer2CarDestroyed; } set { isPlayer2CarDestroyed = value; } }// Свойство для использования в логике мины

    Rigidbody rb;// Для кэширования компонента Rigidbody 


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        isPlayer1CarDestroyed = false;
        isPlayer2CarDestroyed = false;
    }

    // Update is called once per frame
    void Update()
    {
        SetCarRotation();
    }

    private void FixedUpdate()
    {
        SetCarThrottle();
    }

    /// <summary>
    /// Придает машине усколение при нажатии на кнопку 'W' на клавиатуре
    /// </summary>
    private void SetCarThrottle()
    {
        if (gameObject.tag == "Player" && isPlayer1CarDestroyed == false)
        {
            if (Input.GetKey(KeyCode.W))
            {
                rb.AddForce(transform.right * throttlePower);
            }
        }
        else if (gameObject.tag == "Player2" && isPlayer2CarDestroyed == false)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rb.AddForce(transform.right * throttlePower);
            }
        }
       
    }

    /// <summary>
    /// Поворачивает машину влево и вправо при нажатии на кнопку 'A' или 'D' на клавиатуре
    /// </summary>
    private void SetCarRotation()
    {
        if (gameObject.tag == "Player" && isPlayer1CarDestroyed == false)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.up * -rotationSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
            }
        }
        else if (gameObject.tag == "Player2" && isPlayer2CarDestroyed == false)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.up * -rotationSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
            }
        }
       
    }

}
