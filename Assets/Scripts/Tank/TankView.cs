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
        Camera cam = Camera.main;
        cam.transform.parent = this.transform;
        cam.transform.position = new Vector3(0f, 7f, -14f);
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
