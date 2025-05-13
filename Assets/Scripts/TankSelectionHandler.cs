using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class TankSelectionHandler : MonoBehaviour
{
    [SerializeField] private TankTypes tankToSpawn;

    [SerializeField] private TankSpawner spawner;

    [SerializeField] private GameObject tankSelectionPannel;

    private Button currentButton;



    private void Start()
    {
        currentButton = GetComponent<Button>();
        currentButton.onClick.AddListener(SpawnTank);
    }

    private void SpawnTank()
    {
        tankSelectionPannel.SetActive(false);
        spawner.SpawnTank(tankToSpawn);
    }
}
