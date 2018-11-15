using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noodleCollision : MonoBehaviour {

    public PlayerMovement movement;

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "fork")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
