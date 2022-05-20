
# Code of 3D Maze Game
## Level Loader

    using UnityEngine;
    using System.Collections;
    using UnityEngine.SceneManagement;

    public class LevelLoader : MonoBehaviour
    {

    public string levelToLoad;

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(levelToLoad);
    } }
    
## Sound

    using UnityEngine;
    using System.Collections;

    public class Sound : MonoBehaviour
    {
    AudioSource audioData;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            audioData.Pause();
        }
    }}
  
## Timer

    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;

    public class Timer : MonoBehaviour
    {
    float currentTime = 0f;
    public float startTime;
    public string LevelName;

    public Text CountDownText;
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= 1 * Time.deltaTime;
            //print(currentTime);
            CountDownText.text = "Time Remaining: "+currentTime.ToString("0");
        }

        if (currentTime >= 3.5f) { CountDownText.color = Color.black; }
        if (currentTime < 3.5f) { CountDownText.color = Color.red; }
        if (currentTime <= 0f) { Application.LoadLevel(LevelName); }

    } }
