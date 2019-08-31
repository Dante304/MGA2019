using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RavenScript : MonoBehaviour
{
    public Transform positionA;
    public Transform positionB;
    public Transform positionC;
    public float speed;
    
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, positionA.position, speed);
    }
}
