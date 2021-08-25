using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TestNaMesh : MonoBehaviour
{

    [SerializeField]Vector3 size;
    public NavMeshSurface navMeshSurface;

    private void Update()
    {
        size = navMeshSurface.size;
    }
}
