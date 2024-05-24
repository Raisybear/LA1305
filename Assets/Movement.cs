using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 6f; // Die Geschwindigkeit, mit der das Objekt sich horizontal bewegt
    public float jumpForce = 5f; // Die Kraft, mit der das Objekt springt
    public bool isGrounded = false; // Flag, um zu überprüfen, ob das Objekt den Boden berührt
    public bool isWaveMode = false;

    void Update()
    {
        // Bewege das Objekt horizontal nach rechts basierend auf der Geschwindigkeit
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        // Wenn die Leertaste gedrückt wird und das Objekt auf dem Boden ist, springe
        if ((Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0)) && isGrounded)
        {
            Jump();
        }

        else if (isWaveMode == true)
        {
            WaveMove();
        }
    }


    void WaveMove()
    {
        moveSpeed = 9f;

        jumpForce = 10f;

        if (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpForce);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, -jumpForce);
        }
    }

    void Jump()
    {
        // Füge eine vertikale Kraft hinzu, um das Objekt zu springen
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpForce);
        isGrounded = false; // Setze isGrounded auf false, da das Objekt jetzt in der Luft ist
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Überprüfe, ob das Objekt den Boden berührt hat
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        else if (collision.gameObject.CompareTag("WavePortal"))
        {
            SwitchToWaveMode();
        }
    }

    void SwitchToWaveMode()
    {
        isWaveMode = true;
    }
}