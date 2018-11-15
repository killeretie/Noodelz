using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    private float playerScore;

    // Update is called once per frame
    void Update()
    {
        playerScore = (player.position.y * -1 + 2);
        scoreText.text = playerScore.ToString("0");
    }
}
