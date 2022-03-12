
## Lab1-HelloWorldPong2DFile
### Tasks Perform
1. W and S Keys for left paddle
2. Up and Down keys for right Paddle
3. Set the ball bounciness to 1.0f
4. Ball Collision
5. Add friction to paddles so that the ball slows down if movement of paddle is in opposite direction to ball and speeds up if in same direction as ball movement. 
### By Muhammad Saqlain
#### Ball.cs
---

### By Sidra Usman
#### Left Player

    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    public class LeftPlayer : MonoBehaviour {

    private Rigidbody2D rigidBody;
    private Vector2 direction;
    public float speed = 10.0f;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
---

### Complete Code
#### Ball.cs
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
---

#### Left Player.cs
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class LeftPlayer : MonoBehaviour
    {

    private Rigidbody2D rigidBody;
    private Vector2 direction;
    public float speed = 10.0f;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.S))
            direction = Vector2.down;
        else if (Input.GetKey(KeyCode.W))
            direction = Vector2.up;
        else
            direction = Vector2.zero;
        
    }

    void FixedUpdate()
    {
        if (direction.sqrMagnitude != 0)
            rigidBody.AddForce(direction * this.speed);
    }
    }
---

#### Right Player.cs
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class RightPlayer : MonoBehaviour
    {

    private Rigidbody2D rigidBody;
    private Vector2 direction;
    public float speed = 10.0f;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.DownArrow))
            direction = Vector2.down;
        else if (Input.GetKey(KeyCode.UpArrow))
            direction = Vector2.up;
        else
            direction = Vector2.zero;
        
    }

    void FixedUpdate()
    {
        if (direction.sqrMagnitude != 0)
            rigidBody.AddForce(direction * this.speed);
    }
    }



### Video Of Task
https://drive.google.com/file/d/1xIjrSqSwlynExRgvI2d_3sL0iFd0eUAY/view?usp=sharing
