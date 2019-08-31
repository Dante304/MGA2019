using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed;
    public float distanceToChangeSide;
    public Transform startPosition;
    public Transform stopPosition;
    public bool toStop;

    private void Update()
    {
        if (toStop)
        {
            transform.position = Vector2.MoveTowards(transform.position, stopPosition.position, speed);
            if (transform.position.x >= stopPosition.position.x )
            {
                toStop = false;
            }
            
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, startPosition.position, speed);
            if (transform.position.x <= startPosition.position.x)
            {
                toStop = true;
            }
        }
    }
}
