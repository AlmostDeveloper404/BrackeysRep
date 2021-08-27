using UnityEngine;

public class Spawner:MonoBehaviour
{

    public Transform prefabToSpawn;
    private Transform[] spawnPositions;
    public Transform positionsParent;

    private void Start()
    {
        spawnPositions = new Transform[positionsParent.childCount];
        for (int i = 0; i < spawnPositions.Length; i++)
        {
            spawnPositions[i] = positionsParent.GetChild(i);
        }
    }
    public Transform Spawn()
    {
        int randomSpawnPosition = Random.Range(0,spawnPositions.Length);
        Transform prefabTransform= Instantiate(prefabToSpawn,spawnPositions[randomSpawnPosition].position,Quaternion.identity);
        return prefabTransform;
    }

    

    
}
