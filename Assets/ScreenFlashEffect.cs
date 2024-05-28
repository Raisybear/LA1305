using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ScreenFlashEffect : MonoBehaviour
{
    public AudioSource musicSource;
    public Image flashImage;
    public float flashDuration = 0.3f;
    public List<float> syncTimes = new List<float> { 9.7f, 11.5f, 13.1f, 39.5f}; // Liste der Zeitpunkte für den Flash
    public float initialBlackDuration = 2f; // Dauer, wie lange der Bildschirm am Anfang schwarz bleibt

    public int currentSyncIndex = 0;
    public bool isInitialBlackScreen = true;

    public void Start()
    {
        ResetFlashEffect();
    }

    void Update()
    {
        if (musicSource.isPlaying && !isInitialBlackScreen && currentSyncIndex < syncTimes.Count)
        {
            if (Mathf.Abs(musicSource.time - syncTimes[currentSyncIndex]) < Time.deltaTime)
            {
                Flash();
                currentSyncIndex++;
            }
        }
    }

    public void Flash()
    {
        Debug.Log("Flash at time: " + musicSource.time);
        StartCoroutine(FlashRoutine());
    }

    private IEnumerator FlashRoutine()
    {
        flashImage.color = new Color(flashImage.color.r, flashImage.color.g, flashImage.color.b, 1);
        yield return new WaitForSeconds(flashDuration);
        flashImage.color = new Color(flashImage.color.r, flashImage.color.g, flashImage.color.b, 0);
    }

    private IEnumerator InitialBlackScreen()
    {
        yield return new WaitForSeconds(initialBlackDuration);
        flashImage.color = new Color(flashImage.color.r, flashImage.color.g, flashImage.color.b, 0);
        isInitialBlackScreen = false;
    }

    public void ResetFlashEffect()
    {
        Debug.Log("ResetFlashEffect called");

        currentSyncIndex = 0;
        initialBlackDuration = 2f;
        isInitialBlackScreen = true;

        flashImage.color = new Color(flashImage.color.r, flashImage.color.g, flashImage.color.b, 1);

        // Setze die Zeit des Musikclips auf null, um sicherzustellen, dass er synchronisiert ist
        musicSource.Stop();
        musicSource.time = 0f;
        musicSource.Play();

        // Starte die Initialisierungs-Coroutine erneut
        StartCoroutine(InitialBlackScreen());
    }

}
