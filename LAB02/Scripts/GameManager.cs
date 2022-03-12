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
