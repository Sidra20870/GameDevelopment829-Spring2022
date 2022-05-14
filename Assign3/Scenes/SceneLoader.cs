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
    }

}