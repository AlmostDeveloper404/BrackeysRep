using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseManager : MonoBehaviour
{

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
