using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
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
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
