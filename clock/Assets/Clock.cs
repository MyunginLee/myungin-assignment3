using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;
    // Start is called before the first frame update
    
    void Start()
    {
        hoursPivot.localRotation = Quaternion.Euler(0, 0, -30);
        minutesPivot.localRotation = Quaternion.Euler(0, 0, 0);
        secondsPivot.localRotation = Quaternion.Euler(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(DateTime.Now.TimeOfDay.TotalHours);
        hoursPivot.localRotation = Quaternion.Euler(0, 0, -30 * (float)DateTime.Now.TimeOfDay.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0, 0, -6 * (float)DateTime.Now.TimeOfDay.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0, 0, -6 * (float)DateTime.Now.TimeOfDay.TotalSeconds);
    }
}
