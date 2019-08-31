using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock3Script : MonoBehaviour
{
    // Start is called before the first frame update
    int minute = 0;

    private const float hoursToDegrees = 360f / 12f;
    private const float minutesToDegrees = 360f / 60f;
    public Transform hours3, minutes3;

    public void Clock3Clicked()
    {
        ClockRiddleScript.clock3 += 3;
        ClockRiddleScript.clock4 -= 3;
    }

    void Update()
    {
        hours3.localRotation = Quaternion.Euler(0f, 0f, -hoursToDegrees * ClockRiddleScript.clock3);
        minutes3.localRotation = Quaternion.Euler(0f, 0f, -minutesToDegrees * minute);
    }

    private void OnMouseDown()
    {
        Clock3Clicked();
    }

}
