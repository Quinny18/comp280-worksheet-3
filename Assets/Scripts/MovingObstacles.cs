using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacles : MonoBehaviour
{
    [SerializeField]
    //Affects the speed that the obstacles move toward the player
    public static float speed = 100f;
    [SerializeField]
    private Rigidbody rb;


    void Update()
    {
        //Moves rigidbody progressively negative on the z axis
        rb.velocity = new Vector3(0, 0, -speed * Time.deltaTime);

        //Destroys the obstacle once it passes -5 on the z axis
        if (transform.position.z < -5)
        {
            gameObject.SetActive(false);
        }
    }
}
