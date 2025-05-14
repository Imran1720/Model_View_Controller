using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIView : MonoBehaviour
{
    public static UIView instance;

    [SerializeField] private int durationInSeconds;

    [SerializeField] private TextMeshProUGUI timeText;

    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private GameObject gameCompletionScreen;

    private UIController uiController;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {

        uiController = new UIController(this);
        uiController.SetTimer(durationInSeconds);
    }

    private void Update()
    {
        uiController.RunTimer();
    }

    public void UpdateTimerText(int time)
    {
        timeText.text = "" + time;
    }

    public void ShowGameOver()
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ShowGameCompletion()
    {
        gameCompletionScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    public void GameCompleted()
    {
        Invoke("ShowGameCompletion", 2f);
    }


}
