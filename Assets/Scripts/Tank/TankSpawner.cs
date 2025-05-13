using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField]
    private TankView tankView;
    [SerializeField]
    private TankTypes tankToSpawn;

    [SerializeField]
    private List<Tanks> tanksList;


    void Start()
    {
        SpawnTank();
    }

    private void SpawnTank()
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