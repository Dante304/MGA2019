using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollection : MonoBehaviour
{
    public GameObject disableCutsceneTrigger;
    public GameObject activeTextTrigger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            disableCutsceneTrigger.SetActive(false);
            activeTextTrigger.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
