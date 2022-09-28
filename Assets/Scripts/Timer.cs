using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float TotalTime = 120;
    public TextMeshProUGUI TimerText;

    void Start()
    {
        TimerText.text = TotalTime.ToString();
    }

    void Update()
    {
        TotalTime -= Time.deltaTime;
        TimerText.text = Mathf.Round(TotalTime).ToString();
    }
}
