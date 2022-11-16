using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float JumpForce;

    public float score;

    public float scoreIncrease;

    //public GameOverScript GameOverScript;

    [SerializeField]
    bool isGrounded = false;

    Rigidbody2D rb;
    public Text scoreText;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                rb.AddForce(Vector2.up * JumpForce);
                isGrounded = false;
            }
        }

        {
            scoreText.text = "SCORE: " + (int)score;
            score += scoreIncrease * Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene("SampleScene");
            //GameOverScript.showGameOver();
            //GameOverScript.gameOver = true;
        }
    }
}
