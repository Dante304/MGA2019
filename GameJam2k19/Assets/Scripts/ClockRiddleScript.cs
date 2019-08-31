using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockRiddleScript : MonoBehaviour
{
    public static int clock1 = 6;
    public static int clock2 = 6;
    public static int clock3 = 6;
    public static int clock4 = 6;

    void Update()
    {
        ClockSolution();    
    }
    public void ClockSolution()
    {
        if (ClockRiddleScript.clock1 == 12 && ClockRiddleScript.clock2 == 12 && ClockRiddleScript.clock3 == 12)
        {
            //zaprogramować otwarcie drzwi
        }
    }
}

