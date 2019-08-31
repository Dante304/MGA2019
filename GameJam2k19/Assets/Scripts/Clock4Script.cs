using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock4Script : MonoBehaviour
{
    // Start is called before the first frame update
    int minute = 0;

    private const float hoursToDegrees = 360f / 12f;
    private const float minutesToDegrees = 360f / 60f;
    public Transform hours4, minutes4;

    public void Clock4Clicked()
    {
        ClockRiddleScript.clock4 += 3;
        ClockRiddleScript.clock2 -= 3;
    }

    void Update()
    {
        hours4.localRotation = Quaternion.Euler(0f, 0f, -hoursToDegrees * ClockRiddleScript.clock4);
        minutes4.localRotation = Quaternion.Euler(0f, 0f, -minutesToDegrees * minute);
    }

    private void OnMouseDown()
    {
        Clock4Clicked();
    }

}
