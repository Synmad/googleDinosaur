using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject Obstacle;

    public float minSpeed;
    public float maxSpeed;
    public float speed;
    public float acceleration;

    private void Awake()
    {
        speed = minSpeed;
        generateObstacle();
    }

    public void obstacleRandom()
    {
        float randomWait = Random.Range(0.1f, 1.2f);
        Invoke("generateObstacle", randomWait);
    }

    void generateObstacle()
    {
        GameObject ObstacleInstantiate = Instantiate(Obstacle,transform.position,transform.rotation);

        ObstacleInstantiate.GetComponent<Obstacle>().obstacleGenerator = this;
    }

    void Update()
    {
        if (speed < maxSpeed) 
        {
            speed += acceleration;
        }   
    }
}
