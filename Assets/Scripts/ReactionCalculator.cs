using UnityEngine;

public class ReactionCalculator : MonoBehaviour
{
    public static bool IsTimerRunning = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IsTimerRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StopTimer()
    {
        IsTimerRunning = false;
    }
}
