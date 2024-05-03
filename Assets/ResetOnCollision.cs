using UnityEngine;

public class ResetOnCollision : MonoBehaviour
{
    private Vector3 startPosition; // Die Startposition des Objekts

    void Start()
    {
        // Speichere die Startposition des Objekts
        startPosition = transform.position;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Überprüfe, ob das kollidierende Objekt das gewünschte Objekt ist
        if (collision.gameObject.CompareTag("Spike"))
        {
            // Setze das Objekt zur Startposition zurück
            transform.position = startPosition;
        }
    }
}
