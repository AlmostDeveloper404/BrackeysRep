using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void PlayCoinSound()
    {
        audioSource.Play();
    }
    public void Easy()
    {
        SceneManager.LoadScene(4);
    }

    public void Medium()
    {
        SceneManager.LoadScene(1);
    }

    public void Hard()
    {
        SceneManager.LoadScene(5);
    }
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
