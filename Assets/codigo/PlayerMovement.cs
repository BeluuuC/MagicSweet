using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Propiedades del jugador
    public float speed = 5f; // Velocidad de movimiento
    private Rigidbody2D rb;  // Referencia al Rigidbody2D
    private string currentState;  // Estado del jugador ("Idle" o "Moving")

    // Lista para almacenar objetos recogidos (Galletas y Libros)
    private List<string> collectedItems = new List<string>();

    // Start es llamado al inicio
    void Start()
    {
        // Inicializamos el Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
        if (rb == null) Debug.LogError("Rigidbody2D no encontrado en el jugador.");

        currentState = "Idle"; // El jugador empieza en estado "Idle"
    }

    // Update es llamado una vez por frame
    void Update()
    {
        HandleMovement();
        CheckState();
    }

    // Método para manejar el movimiento del jugador
    private void HandleMovement()
    {
        float moveX = Input.GetAxis("Horizontal");  // Detecta las teclas de movimiento (A/D o flechas)

        // Crear un vector para el movimiento
        Vector2 movement = new Vector2(moveX * speed, rb.velocity.y);

        // Aplicar el movimiento al Rigidbody2D
        rb.velocity = movement;

        // Actualizar el estado del jugador dependiendo de si se mueve o no
        if (Mathf.Abs(moveX) > 0.1f)
        {
            currentState = "Moving"; // Si el jugador se mueve
        }
        else
        {
            currentState = "Idle"; // Si el jugador no se mueve
        }
    }

    // Método para revisar y mostrar el estado actual
    private void CheckState()
    {
        Debug.Log("Estado: " + currentState);
    }

    // Método para recoger un objeto
    public void CollectItem(string itemName)
    {
        collectedItems.Add(itemName);
        Debug.Log("Has recogido: " + itemName);
    }

    // Método para listar los objetos recogidos
    public void ListCollectedItems()
    {
        Debug.Log("Objetos recogidos:");
        foreach (string item in collectedItems)
        {
            Debug.Log("- " + item);
        }
    }
}
