using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float smoothSpeed;
    //Positions the camera in the desired angle
    public int zOffset = -20;
    public int yOffset = 12;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        smoothSpeed = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        //Tracking the Players movements
        Vector3 target = new Vector3(player.transform.position.x, player.transform.position.y + yOffset, player.transform.position.z + zOffset);
        Vector3 smoothedPos = Vector3.Lerp(transform.position, target, smoothSpeed);
        transform.position = smoothedPos;
    }
}
