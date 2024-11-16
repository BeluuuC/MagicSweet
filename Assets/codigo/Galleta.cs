using UnityEngine;

public class Galleta : MonoBehaviour
{
    // Detectar colisiones con el jugador
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))  // Si el objeto que colisiona es el jugador
        {
            // Llamamos al método CollectItem del jugador
            other.GetComponent<PlayerMovement>().CollectItem("Galleta");

            // Desactivamos la galleta después de que el jugador la recoja
            gameObject.SetActive(false);
        }
    }
}

