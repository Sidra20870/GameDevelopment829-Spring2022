
## Game Sound Code
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
    }
}
