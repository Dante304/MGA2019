using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextAnimatrion : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public GameObject continueButton;
    

    void Start()
    {
        StartCoroutine(Type());
        continueButton.SetActive(true);
    }

    void Update()
    {
        if (textDisplay.text==sentences[index])
        {
            
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
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
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());    
       
    }
    
}
