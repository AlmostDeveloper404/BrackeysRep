using UnityEngine;

public class SpeakingCoin : MonoBehaviour
{
    AudioSource audioSource;


    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void PlayCoinSound()
    {
        audioSource.Play();
    }
}
