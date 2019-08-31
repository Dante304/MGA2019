using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckpoint : MonoBehaviour
{
    public List<Collider2D> listOfCheckpoints;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!listOfCheckpoints.Contains(collision) && collision.tag == "Checkpoint")
        {
            listOfCheckpoints.Add(collision);
        }

        if (collision.tag == "Enemy")
        {
            this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 5;
            var lastCheckpoint = listOfCheckpoints.Count - 1;
            var checkpointTransform = listOfCheckpoints[lastCheckpoint].transform.position;
            this.transform.position = new Vector2(checkpointTransform.x, checkpointTransform.y);
        }
    }


}
