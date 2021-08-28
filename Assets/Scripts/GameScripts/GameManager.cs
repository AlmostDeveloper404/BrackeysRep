using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int enemyRemain=100;
    public int coinsRemain=20;

    public int AmountOfEnemies;


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


    public void RemoveEnemy()
    {
        enemyRemain--;
        _uiManager.UpdateScore();
    }

    public void RemoveCoin()
    {
        coinsRemain--;
        _uiManager.UpdateScore();
    }

}
