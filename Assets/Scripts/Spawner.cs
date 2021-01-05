/*
 * The Code in this script was taken from the tutorial linked below, with minor adjustments.
 * https://www.youtube.com/watch?v=wGgeCki1vC8
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    // This variable controls how frequently something is spawned.
    private float timeToSpawn = 5f;
    // This variable tracks how long since the last object was spawned. 
    private float timeSinceSpawn;
    // This is just a reference to the object pool.
    public ObjectPooling objectPool;

    // Start is called before the first frame update.
    void Start()
    {
        // Caching a reference to the object pool.
        objectPool = FindObjectOfType<ObjectPooling>();
    }

    // Update is called once per frame.
    void Update()
    {
        // Simple Timer setup.
        timeSinceSpawn += Time.deltaTime;

        // Getting a new coin from the pool, if the time since the last space is greater than or equal to the time to spawn variable.
        if (timeSinceSpawn >= timeToSpawn)
        {
            GameObject newCoin = objectPool.GetCoin();

            // Initialising the object position, to be somewhere within the bounds of the track, given by the two posiitons in the Range function.
            newCoin.transform.position = new Vector3(transform.position.x + Random.Range(-6.5f, 6.5f), transform.position.y, transform.position.z);

            // Resetting the time to spawn, so the timer restarts.
            timeSinceSpawn = 0f;
        }
    }
}
