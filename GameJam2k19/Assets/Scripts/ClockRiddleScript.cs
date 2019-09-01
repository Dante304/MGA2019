using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockRiddleScript : MonoBehaviour
{
    public static int clock1 = 6;
    public static int clock2 = 6;
    public static int clock3 = 6;
    public static int clock4 = 6;
    public GameObject end;
    private static bool doorOpened = false;
    void Update()
    {
        if(doorOpened == false) ClockSolution();    
    }
    public void ClockSolution()
    {
        if (ClockRiddleScript.clock1 % 12 == 0 && ClockRiddleScript.clock2 % 12 == 0 && ClockRiddleScript.clock3 % 12 == 0 && ClockRiddleScript.clock4 % 12 == 0)
        {
            //zaprogramować otwarcie drzwi
            doorOpened = true;
            Debug.Log("Drzwi otwarte");
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().schoolEnd = true;
            end.SetActive(true);
        }
    }
}

