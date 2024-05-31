using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Kollision erkannt mit: " + collision.tag);
        if (collision.tag == "Untagged")
        {
            SceneManager.LoadScene(1);
        }
    }
}