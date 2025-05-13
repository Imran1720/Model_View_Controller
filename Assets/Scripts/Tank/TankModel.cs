
using UnityEngine;

public class TankModel
{

    private float moveSpeed;
    private float rotationSpeed;

    private Material color;
    private TankTypes tankType;

    private TankController tankController;

    public TankModel(Tanks tankData)
    {
        UpdateTankData(tankData);
    }


    public void SetTankController(TankController tankController)
    {
        this.tankController = tankController;
    }

    public float GetTankMoveSpeed() => moveSpeed;
    public float GetTankRotationSpeed() => rotationSpeed;
    public Material GetTankMaterial() => color;

    private void UpdateTankData(Tanks tankData)
    {
        tankType = tankData.tankType;
        moveSpeed = tankData.moveSpeed;
        rotationSpeed = tankData.rotationSpeed;
        color = tankData.color;
    }
}
