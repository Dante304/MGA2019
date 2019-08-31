﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockScript : MonoBehaviour
{
    // Start is called before the first frame update
    int clock1 = 3;
    int clock2 = 6;
    int clock3 = 6;
    int minute = 0;

    private const float hoursToDegrees = 360f / 12f;
    private const float minutesToDegrees = 360f / 60f;
    public Transform hours1, minutes1;
    public void Clock1Clicked()
    {
        ClockRiddleScript.clock1 += 3;
        ClockRiddleScript.clock3 -= 3;
    }

    void Update()
    {
        hours1.localRotation = Quaternion.Euler(0f, 0f, -hoursToDegrees * ClockRiddleScript.clock1);
        minutes1.localRotation = Quaternion.Euler(0f, 0f, -minutesToDegrees * minute);
    }

    private void OnMouseDown()
    {
        Clock1Clicked();
    }
  
}
