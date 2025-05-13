using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField]
    private TankView tankView;



    void Start()
    {
        SpawnTank();
    }

    private void SpawnTank()
    {
        TankModel tankModel = new TankModel();

        TankController controller = new TankController(tankModel, tankView);

        tankModel.SetTankController(controller);
        tankView.SetTankController(controller);
    }
}
