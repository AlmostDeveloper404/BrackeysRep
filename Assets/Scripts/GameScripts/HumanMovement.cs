using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HumanMovement : MonoBehaviour
{
    NavMeshAgent _navMeshAgent;
    Transform targetCoin;
    CoinManager _coinManager;

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        _coinManager = CoinManager.instance;
    }

    private void Update()
    {

        targetCoin = _coinManager.FindNearestCoin(transform.position);

        if (targetCoin!=null && _navMeshAgent.enabled==true)
        {
            _navMeshAgent.SetDestination(targetCoin.position);

        }
    }
}
