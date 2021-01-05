using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnObstacle : MonoBehaviour
{

    private ObstaclesObjectPooling objectPool;

    // Start is called before the first frame update
    private void Start()
    {
        objectPool = FindObjectOfType<ObstaclesObjectPooling>();
    }

    private void OnDisable()
    {
        if (objectPool != null)
        {
            objectPool.ReturnObstacle(this.gameObject);
        }
    }
}
