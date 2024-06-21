using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{	
    public void PlayGame()
    {
        // Level-Menu aufrufen
        SceneManager.LoadSceneAsync(1);
    }
}
