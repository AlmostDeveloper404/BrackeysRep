using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{

    CoinManager _coinManager;

    bool isCollided = false;

    private void Start()
    {
        _coinManager = CoinManager.instance;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<Ragdoll>()!=null && !isCollided)
        {
            _coinManager.PickUpCoin(transform);
            Destroy(gameObject);
            isCollided = true;
        }
    }
}
