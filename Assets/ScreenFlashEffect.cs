using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ScreenFlashEffect : MonoBehaviour
{
    public AudioSource musicSource;
    public Image flashImage;
    public float flashDuration = 0.5f;
    public List<float> syncTimes = new List<float> { 9.7f, 11.5f, 12.5f}; // Liste der Zeitpunkte für den Flash
    public float initialBlackDuration = 2f; // Dauer, wie lange der Bildschirm am Anfang schwarz bleibt
    public int currentSyncIndex = 0;
    public bool isInitialBlackScreen = true;

    void Start()
    {
        Debug.Log("ScreenFlashEffect Start");
        ResetFlashEffect();

        // Starte die Musik sofort
        if (musicSource != null)
        {
            musicSource.Play();
            Debug.Log("Musik gestartet bei Start");
        }
    }

    void Update()
    {
        if (musicSource.isPlaying)
        {
            Debug.Log("Musik läuft, aktuelle Zeit: " + musicSource.time);
        }

        if (!isInitialBlackScreen)
        {
            Debug.Log("Initialer schwarzer Bildschirm beendet");
        }

        if (currentSyncIndex < syncTimes.Count)
        {
            Debug.Log("Nächster Flash-Zeitpunkt: " + syncTimes[currentSyncIndex]);
        }

        if (musicSource.isPlaying && !isInitialBlackScreen)
        {
            while (currentSyncIndex < syncTimes.Count && musicSource.time >= syncTimes[currentSyncIndex])
            {
                Debug.Log("Flash triggered at time: " + musicSource.time + ", Zielzeit: " + syncTimes[currentSyncIndex]);
                Flash();
                currentSyncIndex++;
            }
        }
    }

    public void Flash()
    {
        Debug.Log("Flash Methode aufgerufen");
        StartCoroutine(FlashRoutine());
    }

    private IEnumerator FlashRoutine()
    {
        // Setze die Bildfarbe auf vollständig sichtbar
        flashImage.color = new Color(flashImage.color.r, flashImage.color.g, flashImage.color.b, 1);
        Debug.Log("Flash sichtbar gemacht");

        // Warte für die Flash-Dauer
        yield return new WaitForSeconds(flashDuration);

        // Setze die Bildfarbe zurück auf vollständig transparent
        flashImage.color = new Color(flashImage.color.r, flashImage.color.g, flashImage.color.b, 0);
        Debug.Log("Flash unsichtbar gemacht");
    }

    private IEnumerator InitialBlackScreen()
    {
        Debug.Log("InitialBlackScreen Coroutine gestartet");

        // Warte für die anfängliche schwarze Dauer
        yield return new WaitForSeconds(initialBlackDuration);

        // Setze die Bildfarbe zurück auf vollständig transparent
        flashImage.color = new Color(flashImage.color.r, flashImage.color.g, flashImage.color.b, 0);
        Debug.Log("InitialBlackScreen beendet, Bild ist jetzt transparent");

        // Setze die Flagge, dass der anfängliche schwarze Bildschirm beendet ist
        isInitialBlackScreen = false;
    }

    public void ResetFlashEffect()
    {
        Debug.Log("ResetFlashEffect Methode aufgerufen");

        // Setze die Flash-Einstellungen zurück
        currentSyncIndex = 0;
        isInitialBlackScreen = true;

        if (flashImage != null)
        {
            // Setze die Farbe des Bildschirms auf Schwarz
            flashImage.color = new Color(flashImage.color.r, flashImage.color.g, flashImage.color.b, 1);
            Debug.Log("Bildfarbe auf Schwarz gesetzt");
        }

        // Starte die Coroutine, um den Bildschirm nach einer bestimmten Zeit auf transparent zu setzen
        StartCoroutine(InitialBlackScreen());
    }
}
