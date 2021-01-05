using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCoinPickUp : MonoBehaviour
{
    public int scoreValue;
    public Text score;

    void Start()
    {
        score.text = "Score: 0";
    }

    //This checks if the player has collided with the coins or an obstacle.
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Coins"))
        {
            ChangeScore();
            collider.gameObject.SetActive(false);
        }
        else if (collider.gameObject.CompareTag("Obstacles"))
        {
            //Destroys the player is you collide with a wall
            gameObject.SetActive(false);
        }
    }
    public void ChangeScore()
    {
        scoreValue += 1;
        score.text = "Score: " + scoreValue;
    }

}
