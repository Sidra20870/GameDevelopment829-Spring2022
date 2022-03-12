using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float initialSpeed = 100.0f;
    private Rigidbody2D rigidBall;

    private void Awake()
    {

        rigidBall = GetComponent<Rigidbody2D>();

    }

    // Start is called before the first frame update
    void Start()
    {

        rigidBall.AddForce(new Vector2(1, -1) * initialSpeed);
        
    }

    public void OnCollisionEnter2D(Collision2D hitBy)
    {

        //lab01task
        if (hitBy.gameObject.tag == "LeftPaddle" || hitBy.gameObject.tag == "RightPaddle")
        {
            initialSpeed += 10f;
        }

        if (hitBy.collider.CompareTag("LeftWall"))
        {
            GameManager.gameManager.rightScores();
        }
        else if (hitBy.collider.CompareTag("RightWall"))
        {
            GameManager.gameManager.leftScores();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
