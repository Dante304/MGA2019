using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextScript : MonoBehaviour
{
    public GameObject textBox;
    public string text;
    private bool voicePlay;
    public bool quest;
    public int questNumber;
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.tag == "Player")
        {
            if (!voicePlay)
            {

                if (quest)
                {
                    switch (questNumber)
                    {
                        case 1:
                            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().isCatSave = true;
                            break;
                        case 2:
                            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().isGrandpaHappy = true;
                            break;
                        case 3:
                            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().schoolEnd = true;
                            break;
                    }
                }
            }

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
