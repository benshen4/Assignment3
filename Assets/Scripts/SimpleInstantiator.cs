using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleInstantiator : MonoBehaviour
{
    public GameObject bonusPrefab;
    public GameObject enemyPrefab;

    public GameObject[] bonusPrefabs;

    public Transform bonusSpawnPoint;
    public Transform enemySpawnPoint;

    public Transform[] bonusSpawnPoints;
    public Transform[] enemySpawnPoints;


    // Start is called before the first frame update
    void Start()
    {
        // ManyBonusInstantiate();
        ManyEnemyInstantiate();
        ManyRandomBonusInstantiate();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OneInstantiate()
    {
        Instantiate(bonusPrefab, bonusSpawnPoint);
        Instantiate(enemyPrefab, enemySpawnPoint);
    }


    public void ManyBonusInstantiate()
    {
        for (var i = 0; i < bonusSpawnPoints.Length; i++)
        {
            Instantiate(bonusPrefab, bonusSpawnPoints[i]);
        }
    }
    
    public void ManyEnemyInstantiate()
    {
        for (var i = 0; i < enemySpawnPoints.Length; i++)
        {
            Instantiate(enemyPrefab, enemySpawnPoints[i].transform.position, Quaternion.identity);
        }
    }

    public void ManyRandomBonusInstantiate()
    {
        for (var i = 0; i < bonusSpawnPoints.Length; i++)
        {
            int _randomNumber = Random.Range(0, bonusPrefabs.Length);
            Instantiate(bonusPrefabs[_randomNumber], bonusSpawnPoints[i].transform.position, Quaternion.identity);
        }

    }


}
