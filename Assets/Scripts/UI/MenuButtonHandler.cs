using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class MenuButtonHandler : MonoBehaviour
{

    private Button currentButton;

    private void Start()
    {
        currentButton = GetComponent<Button>();
        currentButton.onClick.AddListener(StartGame);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(Config.level);
    }
}
