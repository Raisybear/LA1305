using UnityEngine;

public class ResetOnCollision : MonoBehaviour
{
    private Vector2 startPosition;

    void Start()
    {
        startPosition = new Vector2(-13.62f, -0.1f);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spike"))
        {
            ResetPosition();
            ScoreManager.deathCount++;
        }
    }

    void ResetPosition()
    {
        transform.position = new Vector3(startPosition.x, startPosition.y, transform.position.z);
        transform.rotation = Quaternion.identity;

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = Vector2.zero;
            rb.angularVelocity = 0f;
        }
    }
}
