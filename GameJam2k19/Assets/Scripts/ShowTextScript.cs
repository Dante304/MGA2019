using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextScript : MonoBehaviour
{
    public GameObject textBox;
    public string text;
    private bool voicePlay;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.tag == "Player")
        {
            voicePlay = true;
            textBox.SetActive(true);
            textBox.GetComponentInChildren<Text>().text = text;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        textBox.SetActive(false);
    }
}
