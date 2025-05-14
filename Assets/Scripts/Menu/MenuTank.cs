using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTank : MonoBehaviour
{
    public static MenuTank Instance;

    [SerializeField]
    private float rotationSpeed;
    private float targetRotation;

    [SerializeField] private Material[] colors;

    [SerializeField] private GameObject[] bodyParts;

    private void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        targetRotation += rotationSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, targetRotation, 0);
    }

    public void SetColor(TankTypes type)
    {
        foreach (GameObject part in bodyParts)
        {
            part.GetComponent<MeshRenderer>().material = GetMaterial(type);
        }
    }

    private Material GetMaterial(TankTypes type)
    {
        switch (type)
        {
            case TankTypes.Blue:
                return colors[1];
            case TankTypes.Red:
                return colors[2];
            default:
                return colors[0];
        }
    }
}
