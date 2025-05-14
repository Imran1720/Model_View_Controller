
using UnityEngine;

public class UIController
{
    private UIView uiView;

    private float timer;
    public UIController(UIView _uiView)
    {
        this.uiView = _uiView;
    }


    public void SetTimer(float duration)
    {
        timer = duration;
    }

    public void RunTimer()
    {
        timer -= Time.deltaTime;
        uiView.UpdateTimerText((int)timer);
        if (timer <= 0)
        {
            uiView.ShowGameOver();
        }
    }

}
