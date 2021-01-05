/*
 * The Code in this script was taken from the tutorial linked below, with minor adjustments.
 * https://www.youtube.com/watch?v=wGgeCki1vC8
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    // Initialising variables.
    [SerializeField]
    private GameObject coinPrefab;
    [SerializeField]
    // This Queue will hold the coin prefabs.
    private Queue<GameObject> coinPool = new Queue<GameObject>();
    [SerializeField]
    // This variable dictates the number of objects that are in the pool to start with.
    private int poolStartSize = 5;

    // Start is called before the first frame update.
    private void Start()
    {
        // This for loop instantiates inactive coin prefabs at the beginnning of play.
        for (int i = 0; i < poolStartSize; i++)
        {
            GameObject coin = Instantiate(coinPrefab);
            coinPool.Enqueue(coin);
            coin.SetActive(false);
        }
    }

    public GameObject GetCoin()
    {
        // This if statement Dequeue's coins and activates them, if the coinPool is more than 0.
        if (coinPool.Count > 0)
        {
            GameObject coin = coinPool.Dequeue();
            coin.SetActive(true);
            return coin;
        }
        else
        {
            GameObject coin = Instantiate(coinPrefab);
            return coin;
        }
    }

    // This method is run by the coin object itself, once it has been disabled. It adds the coin back to the Queue and disables it.
    public void ReturnCoin(GameObject coin)
    {
        coinPool.Enqueue(coin);
        coin.SetActive(false);
    }
}

