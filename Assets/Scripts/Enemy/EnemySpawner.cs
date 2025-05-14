using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyView enemyPrefab;
    private EnemyView enemyView;

    [SerializeField] private Transform[] spawnLocations;


    private void Start()
    {
        EnemyModel enemyModel = new EnemyModel(enemyPrefab.GetMaxHealth());
        SpawnEnemy();
        EnemyController enemyController = new EnemyController(enemyModel, enemyView);
    }

    private void SpawnEnemy()
    {
        int position = Random.Range(0, spawnLocations.Length);

        enemyView = Instantiate(enemyPrefab, spawnLocations[position].position, Quaternion.identity);

    }
}
