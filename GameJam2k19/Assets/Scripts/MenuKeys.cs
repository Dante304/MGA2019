using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuKeys : MonoBehaviour
{
    public GameObject creditsinfo;
    public void PressStartButton()
    {
        SceneManager.LoadScene("Intro");
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void Credits()
    {
        creditsinfo.SetActive(true);
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            creditsinfo.SetActive(false);
        }
    }

    public void QuitCredits()
    {
        creditsinfo.SetActive(false);
    }
}
