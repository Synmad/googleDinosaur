using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public ObstacleGenerator obstacleGenerator;

    void Update()
    {
        transform.Translate(Vector2.left * obstacleGenerator.speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Refresh"))
        {
            obstacleGenerator.obstacleRandom();
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
        }
    }
}
