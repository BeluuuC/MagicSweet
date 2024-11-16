using UnityEngine;

public class Libro : MonoBehaviour
{
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))  
        {
           
            other.GetComponent<PlayerMovement>().CollectItem("Libro");

            // Desactiva el libro cuando el pj lo recoja
            gameObject.SetActive(false);
        }
    }
}


