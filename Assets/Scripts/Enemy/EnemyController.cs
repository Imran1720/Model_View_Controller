
using UnityEngine;

public class EnemyController
{

    private EnemyModel enemyModel;
    private EnemyView enemyView;

    private int enemyHealth;
    public EnemyController(EnemyModel _enemyModel, EnemyView _enemyView)
    {
        enemyModel = _enemyModel;
        enemyView = _enemyView;

        enemyView.SetEnemyController(this);
        enemyModel.SetEnemyController(this);

        enemyHealth = enemyModel.GetEnemyHealth();
    }

    public void TakeDamage()
    {
        enemyModel.SetEnemyHealth(enemyHealth--);
        if (enemyModel.GetEnemyHealth() <= 0)
        {
            UIView.instance.GameCompleted();
            DestroyEnemy();
        }
    }

    public void DestroyEnemy()
    {
        GameObject.Destroy(enemyView.gameObject, 1f);
    }
}

