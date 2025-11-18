using Unity.VisualScripting;
using UnityEngine;

public class ReactionCalculator : MonoBehaviour
{
    public static bool IsTimerRunning = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IsTimerRunning = true;
    }
    
    public void StopTimer()
    {
        IsTimerRunning = false;
    }

    public void RestartTimer()
    {
        IsTimerRunning = true;
        TimerText.Time = 0f;
        TimerText.Text.text = TimerText.Time.ToString();
    }
}
