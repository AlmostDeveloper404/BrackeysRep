using UnityEngine;

public class SpeakingCoin : MonoBehaviour
{
    AudioSource audioSource;
    public AudioSource MenuMusic;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void PlayCoinSound()
    {
        audioSource.Play();
    }

    public void PlayMenuMusic()
    {
        MenuMusic.Play();
    }
}
