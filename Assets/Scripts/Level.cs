using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(0);
    }

    public void LaodMainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void nApplicationQuit()
    {
        Application.Quit();
    }
}
