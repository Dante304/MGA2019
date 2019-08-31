using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuKeys : MonoBehaviour
{
    public GameObject creditsinfo;
    public void PressStartButton()
    {
        SceneManager.LoadScene("Level1");
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
        
    }
}
