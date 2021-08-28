using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Test : MonoBehaviour
{
   

    void Update()
    {
        NavMeshHit hit;
        if (NavMesh.SamplePosition(transform.position, out hit, 500f, NavMesh.AllAreas))
        {
            Debug.DrawRay(hit.position, Vector3.up);
        }
    }
}
