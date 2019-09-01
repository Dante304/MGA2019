using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{
    public GameController gameController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && gameController.isCatSave && gameController.isGrandpaHappy && gameController.schoolEnd)
        {
            SceneManager.LoadScene("Outro-Good");
        }
        else if (collision.tag == "Player")
        {
            SceneManager.LoadScene("Outro-Bad");
        }
    }

}
