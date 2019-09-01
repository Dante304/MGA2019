using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phonografPlay : MonoBehaviour
{
    public bool isPlaying;
    public Animator anim;
    public AudioSource audio;
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (!isPlaying)
            {
                audio.Play();
            }
            isPlaying = true;
            anim.SetBool("isPlaying", isPlaying);
        }
    }

    private void Update()
    {
        var dystans = Vector2.Distance(transform.position, player.transform.position);
        dystans = dystans / 25;
        audio.volume = 0.5f - dystans;
        Debug.Log("Dystans " + dystans + "Audio Volume "+ audio.volume);
    }


}
