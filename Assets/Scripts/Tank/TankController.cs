
using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;

    private Rigidbody rb;

    private int rotationMultiplier = 1;

    public TankController(TankModel _tankModel, TankView _tankView)
    {
        tankModel = _tankModel;
        _tankView.SetTankMaterial(_tankModel.GetTankMaterial());
        tankView = GameObject.Instantiate(_tankView);
        rb = tankView.GetRigidbody();

        tankModel.SetTankController(this);
        tankView.SetTankController(this);
    }

    public void MoveTank(float _movementInput)
    {
        rb.velocity = tankView.transform.forward * _movementInput * tankModel.GetTankMoveSpeed();
    }

    public void RotateTank(float _rotationInput, float _movementVector)
    {
        rotationMultiplier = _movementVector >= 0 ? 1 : -1;
        Vector3 roatationVector = new Vector3(0f, _rotationInput * tankModel.GetTankRotationSpeed(), 0f);
        Quaternion deltaRotation = Quaternion.Euler(roatationVector * Time.deltaTime * rotationMultiplier);
        rb.MoveRotation(rb.rotation * deltaRotation);

    }
}
