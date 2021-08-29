using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    #region Singleton
    public static UIManager instance;

    private void Awake()
    {
        if (instance!=null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }
    #endregion

    GameManager _gameManager;
    public Text scoreText;

    private void Start()
    {
        _gameManager = GameManager.instance;
        UpdateScore();
    }

    public void UpdateScore()
    {
        scoreText.text = "Coins: " + _gameManager.coinsRemain + " / " + _gameManager.enemyRemain + " :Humans";
    }
}
