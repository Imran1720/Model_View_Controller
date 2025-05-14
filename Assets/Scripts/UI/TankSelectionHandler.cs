using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class TankSelectionHandler : MonoBehaviour
{
    [SerializeField] private TankTypes tankToSpawn;

    private Button currentButton;


    private void Start()
    {
        PlayerPrefs.SetInt(Config.selectedTank, (int)tankToSpawn);
        currentButton = GetComponent<Button>();
        currentButton.onClick.AddListener(SelectTank);
    }

    private void SelectTank()
    {
        PlayerPrefs.SetInt(Config.selectedTank, (int)tankToSpawn);
        MenuTank.Instance.SetColor(tankToSpawn);
    }

}
