using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tomatoCollider : MonoBehaviour {

    public PlayerMovement movement;

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().CompleteLevel();
        }
    }
}
