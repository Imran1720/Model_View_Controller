using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;


    void Start()
    {

    }
    public void SetTankController(TankController tankController)
    {
        this.tankController = tankController;
    }
}
