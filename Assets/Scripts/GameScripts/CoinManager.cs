using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    #region Singleton
    public static CoinManager instance;

    private void Awake()
    {
        if (instance!=null)
        {
            Debug.LogWarning("More than one CoinManager");
            return;
        }
        instance = this;
    }
    #endregion


    public List<Transform> coins = new List<Transform>();

    public GameObject particle;
    UIManager _uiManager;
    public CoinSpawner _coinSpawner;

    private void Start()
    {
        _uiManager = UIManager.instance;
    }

    public Transform FindNearestCoin(Vector3 human)
    {
        float minDistance = Mathf.Infinity;
        Transform nearestCoin = null;
        for (int i = 0; i < coins.Count; i++)
        {
            float distance = Vector3.Distance(human,coins[i].transform.position);
            if (distance<minDistance)
            {
                minDistance = distance;
                nearestCoin = coins[i];
            }
        }
        return nearestCoin;
    }

    public void PickUpCoin(Transform coin)
    {

        GameObject particleGO = Instantiate(particle,coin.position+new Vector3(0f,.5f,0f),coin.rotation);
        Destroy(particleGO,1f);
        coins.Remove(coin);
        GameManager.coinsRemain--;
        _uiManager.UpdateScore();
        if (coins.Count==0)
        {
            Debug.Log("Game Over Logic");
            return;
        }
        if (GameManager.coinsRemain>coins.Count)
        {
            coins.Add(_coinSpawner.Spawn());
        }
    }

}
