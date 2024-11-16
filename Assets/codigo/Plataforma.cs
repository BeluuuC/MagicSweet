using UnityEngine;

public class Plataforma : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Si el jugador entra en la plataforma
        if (collision.CompareTag("Player"))
        {
            // Fijar al jugador a la plataforma (se convierte en hijo de la plataforma)
            collision.transform.SetParent(transform);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // Si el jugador sale de la plataforma
        if (collision.CompareTag("Player"))
        {
            // El jugador deja de ser hijo de la plataforma
            collision.transform.SetParent(null);
        }
    }
}
