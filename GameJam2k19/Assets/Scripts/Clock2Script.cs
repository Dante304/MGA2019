using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock2Script : MonoBehaviour
{
    // Start is called before the first frame update
    int clock1 = 3;
    int clock2 = 6;
    int clock3 = 6;
    int minute = 0;

    private const float hoursToDegrees = 360f / 12f;
    private const float minutesToDegrees = 360f / 60f;
    public Transform hours2, minutes2;
    public void Clock2Clicked()
    {
        ClockRiddleScript.clock2 += 3;
        ClockRiddleScript.clock1 -= 3;
    }

    void Update()
    {
        hours2.localRotation = Quaternion.Euler(0f, 0f, -hoursToDegrees * ClockRiddleScript.clock2);
        minutes2.localRotation = Quaternion.Euler(0f, 0f, -minutesToDegrees * minute);
    }

    private void OnMouseDown()
    {
        Clock2Clicked();
    }
   
}
