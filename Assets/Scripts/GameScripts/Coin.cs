using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class Coin : MonoBehaviour
{
    NavMeshAgent _navMeshAgent;
    [SerializeField]float triggerRadius;

    [SerializeField]float idleMovementSpeed = 1.5f;
    [SerializeField]float runningMovementSpeed = 2.3f;

    Collider nearestHuman;

    [SerializeField]Transform[] pointRandomPositions;
    public Transform randomPositionsStuck;


    [SerializeField]int randomPosition;

    

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        pointRandomPositions = new Transform[randomPositionsStuck.childCount];
        for (int i = 0; i < pointRandomPositions.Length; i++)
        {
            pointRandomPositions[i] = randomPositionsStuck.GetChild(i);
        }
        randomPosition = Random.Range(0,pointRandomPositions.Length);
    }
    public Collider FindNearestHuman()
    {
        Collider[] humans= Physics.OverlapSphere(transform.position,triggerRadius);

        Collider nearestHuman = null;
        float minDistance = Mathf.Infinity;
        foreach (Collider human in humans)
        {
            if (human.GetComponent<HumanMovement>()!=null)
            {
                float distance = Vector3.Distance(transform.position,human.transform.position);
                if (distance<minDistance)
                {
                    minDistance = distance;
                    nearestHuman = human;
                }
            }
        }
        return nearestHuman;
    }

    private void Update()
    {
        if (FindNearestHuman()!=null)
        {
            nearestHuman = FindNearestHuman();
            RunAwayFromHuman();
        }
        else
        {
            FreelyMovement();
        }
    }

    void RunAwayFromHuman()
    {
        _navMeshAgent.speed = runningMovementSpeed;
        Vector3 dirToHuman = transform.position-nearestHuman.transform.position;
        Vector3 runAwayVector = transform.position + dirToHuman;
        _navMeshAgent.SetDestination(runAwayVector);
    }
    void FreelyMovement()
    {
        _navMeshAgent.speed = idleMovementSpeed;
        _navMeshAgent.SetDestination(pointRandomPositions[randomPosition].position);
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position,triggerRadius);
    }
}
