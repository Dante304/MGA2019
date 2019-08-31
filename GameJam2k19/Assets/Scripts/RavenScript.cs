using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RavenScript : MonoBehaviour
{
    public Transform positionA;
    public Transform positionB;
    public Transform positionC;
    public Transform positionD;
    public bool end;
    public float speed;
    public float toPosition;
    
    void Update()
    {
        RavenMove();
    }

    private void RavenMove()
    {
        if (Vector2.Distance(transform.position, positionA.position) < 1)
        {
            toPosition = 2;
        }
        if (Vector2.Distance(transform.position, positionB.position) < 1)
        {
            toPosition = 3;
        }
        if (Vector2.Distance(transform.position, positionC.position) < 1)
        {
            toPosition = 1;
        }
        if (end)
        {
            toPosition = 4;
        }

        switch (toPosition)
        {
            case 1:
                transform.position = Vector2.MoveTowards(transform.position, positionA.position, speed);
                break;
            case 2:
                transform.position = Vector2.MoveTowards(transform.position, positionB.position, speed);
                break;
            case 3:
                transform.position = Vector2.MoveTowards(transform.position, positionC.position, speed);
                break;
            case 4:
                transform.position = Vector2.MoveTowards(transform.position, positionD.position, speed);
                break;
            default:
                break;
        }

    }
}
