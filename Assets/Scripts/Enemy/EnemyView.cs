using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyView : MonoBehaviour
{
    [SerializeField] private int maxHealth;

    private EnemyController enemyController;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<ShellHandler>() != null)
        {
            enemyController.TakeDamage();
        }
    }

    public int GetMaxHealth() => maxHealth;

    public void SetEnemyController(EnemyController _enemyController)
    {
        enemyController = _enemyController;
    }
}
