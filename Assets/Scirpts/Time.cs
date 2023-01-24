using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time : MonoBehaviour
{
    private const float
        hoursToDegrees = 360f / 12f,
        minutesToDegrees = 360f / 60f,
        secondsToDegrees = 360f / 60f;
    internal static float deltaTime;
    internal static float unscaledDeltaTime;
    public Transform hours, minutes, seconds;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DateTime time = DateTime.Now;
        hours.localRotation = Quaternion.Euler(0 + time.Hour * hoursToDegrees, 0f, 0f);
        minutes.localRotation = Quaternion.Euler(0 + time.Minute * minutesToDegrees, 0f, 0f);
        seconds.localRotation = Quaternion.Euler(0 + time.Second * secondsToDegrees, 0f, 0f);
    }
}
