using UnityEngine;
using System.Collections;

public class Ragdoll : MonoBehaviour
{

    GameManager _gameManager;
    HumanSpawner _humanSpawner;

    public Transform PlaceForParticles;

    public GameObject DeathParticle;
    private void Start()
    {
        _gameManager = GameManager.instance;
        _humanSpawner = HumanSpawner.instance;
        StartCoroutine(PlayZombiSound());
    }
    public void Death()
    {
        GameObject part= Instantiate(DeathParticle, PlaceForParticles.position, Quaternion.identity);
        Destroy(part,1f);

        Destroy(gameObject);
        _gameManager.RemoveEnemy();
        if (_gameManager.enemyRemain>=_gameManager.AmountOfEnemies)
        {
            _humanSpawner.Spawn();
        }
    }

    IEnumerator PlayZombiSound()
    {
        while (true)
        {
            yield return new WaitForSeconds(4f);
        }
    }

    
}
