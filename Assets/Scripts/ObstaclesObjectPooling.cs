using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesObjectPooling : MonoBehaviour
{
    [SerializeField]
    private GameObject obstaclePrefab;
    [SerializeField]
    private Queue<GameObject> obstaclePool = new Queue<GameObject>();
    [SerializeField]
    private int poolStartSize = 5;

    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 0; i < poolStartSize; i++)
        {
            GameObject obstacle = Instantiate(obstaclePrefab);
            obstaclePool.Enqueue(obstacle);
            obstacle.SetActive(false);
        }
    }

    public GameObject GetObstacle()
    {
        if (obstaclePool.Count > 0)
        {
            GameObject obstacle = obstaclePool.Dequeue();
            obstacle.SetActive(true);
            return obstacle;
        }
        else
        {
            GameObject obstacle = Instantiate(obstaclePrefab);
            return obstacle;
        }
    }

    public void ReturnObstacle(GameObject obstacle)
    {
        obstaclePool.Enqueue(obstacle);
        obstacle.SetActive(false);
    }
}
