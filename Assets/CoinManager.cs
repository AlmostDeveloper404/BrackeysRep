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
}
