using UnityEngine;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour
{
    public float moveSpeed = 6f; // Die Geschwindigkeit, mit der das Objekt sich horizontal bewegt
    public float jumpForce = 5f; // Die Kraft, mit der das Objekt springt
    public bool isGrounded = false; // Flag, um zu überprüfen, ob das Objekt den Boden berührt
    public bool isWaveMode = false;

    public void ResetToDefaultMode()
    {
        isWaveMode = false;
    }

    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);

        // Bewege das Objekt horizontal nach rechts basierend auf der Geschwindigkeit
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        // Wenn die Leertaste gedrückt wird und das Objekt auf dem Boden ist, springe
        if ((Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0)) && isGrounded)
        {
            Jump();
        }
        
        // Wenn die Escape-Taste gedrückt wird, lade die Hauptmenüszene
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadSceneAsync(1);
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
        moveSpeed = 8f;
        jumpForce = 13f;

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

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("WavePortal"))
        {
            SwitchToWaveMode();
        }
        if (collision.CompareTag("CubePortal"))
        {
            SwitchToCubeMode();
        }

    }

    void SwitchToWaveMode()
    {
        isWaveMode = true;
    }

    void SwitchToCubeMode()
    {
        isWaveMode = false;
    }
}