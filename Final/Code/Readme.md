
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
    
## Menu Scene Loader
    
    using System;
    using UnityEngine;

    public class MenuSceneLoader : MonoBehaviour
    {
    public GameObject menuUI;

    private GameObject m_Go;

	void Awake ()
	{
	    if (m_Go == null)
	    {
	        m_Go = Instantiate(menuUI);
	    }
	} }

## Scene Loader
    using UnityEngine;
    using System.Collections;

    public class SceneLoader : MonoBehaviour
    {
    public void NextLevelButton(int index)
    {
        Application.LoadLevel(index);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void ExitLevel()
    {
        Application.LoadLevel("Home");
    }
    public void Retry1()
    {
        Application.LoadLevel("Level 1");
    }

    public void Retry2()
    {
        Application.LoadLevel("Level 2");
    } }

## Third Person CHaracter

            using System;
            using UnityEngine;
            using UnityStandardAssets.CrossPlatformInput;

            namespace UnityStandardAssets.Characters.ThirdPerson
            {
            [RequireComponent(typeof (ThirdPersonCharacter))]
            public class ThirdPersonUserControl : MonoBehaviour
            {
            private ThirdPersonCharacter m_Character; // A reference to the ThirdPersonCharacter on the object
            private Transform m_Cam;                  // A reference to the main camera in the scenes transform
            private Vector3 m_CamForward;             // The current forward direction of the camera
            private Vector3 m_Move;
            private bool m_Jump;                      // the world-relative desired move direction, calculated from the camForward and user input.

        
            private void Start()
            {
            // get the transform of the main camera
            if (Camera.main != null)
            {
                m_Cam = Camera.main.transform;
            }
            else
            {
                Debug.LogWarning(
                    "Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls.", gameObject);
                // we use self-relative controls in this case, which probably isn't what the user wants, but hey, we warned them!
            }

            // get the third person character ( this should never be null due to require component )
            m_Character = GetComponent<ThirdPersonCharacter>();
            }


            private void Update()
            {
            if (!m_Jump)
            {
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
            }
            }


            // Fixed update is called in sync with physics
            private void FixedUpdate()
            {
            // read inputs
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
            bool crouch = Input.GetKey(KeyCode.C);

            // calculate move direction to pass to character
            if (m_Cam != null)
            {
                // calculate camera relative direction to move:
                m_CamForward = Vector3.Scale(m_Cam.forward, new Vector3(1, 0, 1)).normalized;
                m_Move = v*m_CamForward + h*m_Cam.right;
            }
            else
            {
                // we use world-relative directions in the case of no main camera
                m_Move = v*Vector3.forward + h*Vector3.right;
            }

			// walk speed multiplier
	        if (Input.GetKey(KeyCode.LeftShift)) m_Move *= 0.5f;
            #endif

            // pass all parameters to the character control script
            m_Character.Move(m_Move, crouch, m_Jump);
            m_Jump = false;
        }
    } }


    
