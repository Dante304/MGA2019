using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceScript : MonoBehaviour
{
    public GameObject fence;

    private void OnMouseEnter()
    {
        fence.GetComponent<BoxCollider2D>().isTrigger = true;
    }

    private void OnMouseExit()
    {
        fence.GetComponent<BoxCollider2D>().isTrigger = false ;
    }

}
