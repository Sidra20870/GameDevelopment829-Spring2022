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

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "LeftPaddle" || collision.gameObject.tag == "RightPaddle")
        {
            initialSpeed += 10f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
