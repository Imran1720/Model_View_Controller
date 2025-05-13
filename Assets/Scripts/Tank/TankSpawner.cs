using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField]
    private TankView tankView;

    [SerializeField]
    private List<Tanks> tanksList;

    public void SpawnTank(TankTypes tankToSpawn)
    {
        TankModel tankModel = new TankModel(tanksList[(int)tankToSpawn]);

        TankController controller = new TankController(tankModel, tankView);
    }
}


[Serializable]

public class Tanks
{
    public TankTypes tankType;
    public float moveSpeed;
    public float rotationSpeed;
    public Material color;
}