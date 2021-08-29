using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class GameManager : MonoBehaviour
{
    public int enemyRemain=100;
    public int coinsRemain=20;

    public GameObject MenuIntoGame;

    public int AmountOfEnemies;

    public FirstPersonController firstPersonController;
    public Gun gun;

    public Text statictics;

    #region Singleton
    public static GameManager instance;

    private void Awake()
    {
        if (instance!=null)
        {
            Debug.LogWarning("More than one GameManager");
            return;
        }
        instance = this;
    }

    #endregion Singleton

    UIManager _uiManager;

    private void Start()
    {
        _uiManager = UIManager.instance;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    void Pause()
    {
        firstPersonController.enabled = false;
        MenuIntoGame.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        gun.enabled = false;
    }


    public void RemoveEnemy()
    {
        if (enemyRemain==1)
        {
            SceneManager.LoadScene(3);
        }
        enemyRemain--;
        _uiManager.UpdateScore();
    }

    public void RemoveCoin()
    {
        if (coinsRemain==1)
        {
            SceneManager.LoadScene(2);
        }
        coinsRemain--;
        _uiManager.UpdateScore();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void BackToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void CloseButton()
    {

        Reset();
        
    }

    private void Reset()
    {
        firstPersonController.enabled = true;
        MenuIntoGame.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
        gun.enabled = true;
    }
}
