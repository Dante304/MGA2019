using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSmoothMovment : MonoBehaviour
{
    private Vector2 velocity;
    public float smoothTimeX;
    public float smoothTimeY;

    public GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }

    private void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
        
        float posY = Mathf.SmoothDamp(transform.position.y+1, player.transform.position.y+1, ref velocity.y, smoothTimeY);
        
        transform.position = new Vector3(posX, posY, transform.position.z);


    }


}
