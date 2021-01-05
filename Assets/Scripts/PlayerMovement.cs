using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //moveSpeed's value affects the player horizontal movement speed
    public float moveSpeed;
    //speedInput is the value that is being sent in from the potentiometer
    public float speedInput;
    //rb refers to the player gameobjects rigidbody
    public Rigidbody rb;

    Vector3 Movement;

    void Update()
    {
       //Movement.x is collecting the users movement input
        Movement.x = Input.GetAxisRaw("Horizontal");

        //These various if statements are comparing the input from the potentiometer and setting the move speed of the obstacles accordingly
        if (speedInput < 50f)
        {
            MovingObstacles.speed = 900f;
        }
        else if (speedInput > 50f && speedInput < 350f)
        {
            MovingObstacles.speed = 1850f;
        }
        else if (speedInput >= 350f)
        {
            MovingObstacles.speed = 2550f;
        }
        else if (speedInput >= 550f)
        {
            MovingObstacles.speed = 3550f;
        }
        else if (speedInput >= 750f)
        {
            MovingObstacles.speed = 4100f;
        }
        else if (speedInput >= 900f)
        {
            MovingObstacles.speed = 4500f;
        }
    }

    //The fixed update is used to apply the physics to the player's rigidbody
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + Movement * moveSpeed * Time.fixedDeltaTime);
    }

}
