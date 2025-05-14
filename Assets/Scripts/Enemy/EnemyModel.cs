
public class EnemyModel
{
    private int health;

    private EnemyController enemyController;
    public EnemyModel(int _health)
    {
        health = _health;
    }

    public int GetEnemyHealth() => health;

    public void SetEnemyHealth(int value) => health = value;

    public void SetEnemyController(EnemyController _enemyController) => enemyController = _enemyController;

}
