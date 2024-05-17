using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepCameraLevel : MonoBehaviour
{
    // Update is called once per frame
    void LateUpdate()
    {
        // Setzt die Rotation der Kamera zurück, sodass sie immer horizontal bleibt
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
