

## Lab2-GameManagerForPong2D
### Tasks Perform
1. W and S Keys for left paddle
2. Up and Down keys for right Paddle
3. Set the ball bounciness to 1.0f
4. Ball Collision
5. Add friction to paddles so that the ball slows down if movement of paddle is in opposite direction to ball and speeds up if in same direction as ball movement. 
6. Display and update scores for both players.
7. Reset the game once a player scores.
8. Display the winning message.
### By Sidra Usman
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

---

### By Muhammad Saqlain
#### Game Manager

    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;

    public class GameManager : MonoBehaviour
    {

    public static GameManager gameManager = null;
    private int LeftScore = 0;
    private int RightScore = 0;

    public Text LeftPlayerScore;
    public Text RightPlayerScore;

    public GameObject ball;
    public GameObject LeftPlayerWinScreen;
    public GameObject RightPlayerWinScreen;

    private void Awake()
    {
        //enforce singleton
        if (gameManager == null)
        {
            gameManager = this;
        }
    }
    public void leftScores()
    {
        LeftScore++;
        Debug.Log("Left Player Score: " + LeftScore);
        ball.transform.position = new Vector3(0f, 0f, 0f);
    }
    public void rightScores()
    {
        RightScore++;
        Debug.Log("Right Player Score: " + RightScore);
        ball.transform.position = new Vector3(0f, 0f, 0f);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        LeftPlayerScore.text = "Left Player Score: " + LeftScore;
        RightPlayerScore.text = "Right Player Score: " + RightScore;

        if (LeftScore == 10)
        {

            LeftPlayerWinScreen.SetActive(true);
            Time.timeScale = 0;

        }

        if (RightScore == 10)
        {

            RightPlayerWinScreen.SetActive(true);
            Time.timeScale = 0;

        }
        
    }
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

---
#### Game Manager.cs
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;

    public class GameManager : MonoBehaviour
    {

    public static GameManager gameManager = null;
    private int LeftScore = 0;
    private int RightScore = 0;

    public Text LeftPlayerScore;
    public Text RightPlayerScore;

    public GameObject ball;
    public GameObject LeftPlayerWinScreen;
    public GameObject RightPlayerWinScreen;

    private void Awake()
    {
        //enforce singleton
        if (gameManager == null)
        {
            gameManager = this;
        }
    }
    public void leftScores()
    {
        LeftScore++;
        Debug.Log("Left Player Score: " + LeftScore);
        ball.transform.position = new Vector3(0f, 0f, 0f);
    }
    public void rightScores()
    {
        RightScore++;
        Debug.Log("Right Player Score: " + RightScore);
        ball.transform.position = new Vector3(0f, 0f, 0f);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        LeftPlayerScore.text = "Left Player Score: " + LeftScore;
        RightPlayerScore.text = "Right Player Score: " + RightScore;

        if (LeftScore == 10)
        {

            LeftPlayerWinScreen.SetActive(true);
            Time.timeScale = 0;

        }

        if (RightScore == 10)
        {

            RightPlayerWinScreen.SetActive(true);
            Time.timeScale = 0;

        }
        
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
https://drive.google.com/file/d/1VP14LM3X0bMkZ9K_NBorn3Gwps5SX2AH/view?usp=sharing
