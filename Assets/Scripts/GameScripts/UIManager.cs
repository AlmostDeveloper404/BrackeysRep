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

    public Text scoreText;

    private void Start()
    {
        UpdateScore();
    }

    public void UpdateScore()
    {
        scoreText.text = GameManager.coinsRemain + " / " + GameManager.enemyRemain;
    }
}
