using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;

    private float movementInput;
    private float rotationInput;

    [SerializeField] private Rigidbody rb;

    [SerializeField] private MeshRenderer[] bodyParts;


    public void SetTankController(TankController tankController)
    {
        this.tankController = tankController;
    }

    private void Start()
    {
        DynamicGI.UpdateEnvironment();
        Camera cam = Camera.main;
        cam.GetComponentInParent<CameraController>().SetTarget(this.transform);
    }

    private void Update()
    {
        movementInput = Input.GetAxis("Vertical");
        rotationInput = Input.GetAxis("Horizontal");

    }

    private void FixedUpdate()
    {
        if (movementInput != 0) tankController.MoveTank(movementInput);

        if (rotationInput != 0) tankController.RotateTank(rotationInput, movementInput);

    }

    public Rigidbody GetRigidbody() => rb;

    public void SetTankMaterial(Material color)
    {
        foreach (MeshRenderer renderer in bodyParts)
        {
            renderer.material = color;
        }
    }
}
