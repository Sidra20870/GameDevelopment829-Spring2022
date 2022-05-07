using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public string levelToLoad;

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(levelToLoad);
    }

}