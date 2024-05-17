using UnityEngine;

public class KeepCameraLevel : MonoBehaviour
{
    void LateUpdate()
    {
        // Setzt die Rotation der Kamera zurück, sodass sie immer horizontal bleibt
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}