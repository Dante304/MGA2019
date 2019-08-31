using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextCutscenes : MonoBehaviour
{
    public GameObject textDisplayGameobject;
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    private bool voicePlay;
    public float typingSpeed;
    public GameObject player;
    public bool triggerDeactivated;

    public GameObject continueButton;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !triggerDeactivated)
        {
            if (!voicePlay)
            {
                voicePlay = true;
                player.GetComponent<PlayerMove>().stop = true;
                continueButton.SetActive(true);
                textDisplayGameobject.SetActive(true);
                StartCoroutine(Type());
            }
        }
    }

    void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }
    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {

        continueButton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
            player.GetComponent<PlayerMove>().stop = false;
        }
    }
}
