using UnityEngine;

public class TimerText : MonoBehaviour
{
    public static TMPro.TMP_Text Text;
    public TMPro.TMP_Text timerText;
    public static float Time;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (timerText != null)
        {
            Text = timerText;
        }
        else
        {
            Debug.LogError("couldn't set static field");
        }
    }

    // Update is called once per frame
    void Update()
    {
        IncrementTimer();
        updateTimerText();
    }

    public void updateTimerText()
    {
        Text.text = Time.ToString();
    }

    public void IncrementTimer()
    {
        if (ReactionCalculator.IsTimerRunning)
        {
            Time+=UnityEngine.Time.deltaTime;
        }
        else
        {
            return;
        }
    }
}
