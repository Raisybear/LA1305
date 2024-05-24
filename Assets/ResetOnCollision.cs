using UnityEngine;

public class ResetOnCollision : MonoBehaviour
{
    public AudioSource audioSource;
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
            ResetPosition();

            ScoreManager.deathCount++;

            audioSource.Stop(); // Stoppe die Wiedergabe
            audioSource.time = 0f; // Setze die Wiedergabezeit auf den Anfang
            audioSource.Play(); // Starte die Wiedergabe erneut
        }
    }

    void ResetPosition()
    {
        // Setze die Position des Objekts auf die Startposition zurück
        transform.position = new Vector3(startPosition.x, startPosition.y, transform.position.z);
        // Setze die Rotation des Objekts zurück
        transform.rotation = Quaternion.identity;
        // Setze die Geschwindigkeit des Objekts zurück (falls es sich bewegt)
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = Vector2.zero;
            rb.angularVelocity = 0f;
        }

        // Setze den Spielmodus zurück
        Movement movementScript = GetComponent<Movement>();
        if (movementScript != null)
        {
            movementScript.ResetToDefaultMode();
        }
    }
}