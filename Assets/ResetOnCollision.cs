using UnityEngine;

public class ResetOnCollision : MonoBehaviour
{
    private Vector2 startPosition; // Die Startposition des Objekts

    void Start()
    {
        // Setze die Startposition des Objekts auf die angegebenen Koordinaten
        startPosition = new Vector2(-13.62f, -0.1f);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Überprüfe, ob das kollidierende Objekt das gewünschte Objekt ist
        if (collision.gameObject.CompareTag("Spike"))
        {
            // Setze das Objekt zur Startposition zurück
            transform.position = new Vector3(startPosition.x, startPosition.y, transform.position.z);
        }
    }
}
