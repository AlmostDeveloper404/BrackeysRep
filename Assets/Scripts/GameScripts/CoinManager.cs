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

    GameManager _gameManager;

    public GameObject particle;
    public CoinSpawner _coinSpawner;

    AudioSource _audioSourse;

    
    private void Start()
    {
        _audioSourse = GetComponent<AudioSource>();
        _gameManager = GameManager.instance;
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
        AudioManager.instance.audios[0].Play();
        GameObject particleGO = Instantiate(particle,coin.position+new Vector3(0f,.5f,0f),coin.rotation);
        Destroy(particleGO,1f);

        coins.Remove(coin);

        _gameManager.RemoveCoin();
        if (coins.Count==0)
        {
            Debug.Log("Game Over Logic");
            return;
        }
        if (_gameManager.coinsRemain>coins.Count)
        {
            _audioSourse.Play();
            coins.Add(_coinSpawner.Spawn());
        }
        
    }

}
