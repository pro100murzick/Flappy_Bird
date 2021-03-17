using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{

    [SerializeField] GameObject[] gameOverComponents;
    [SerializeField] GameObject[] startOverComponents;
    [SerializeField] GameObject scoreObject;

    void Start()
    {
        Time.timeScale = 1; //Возобновление игры после паузы
        DisableUIComonents(gameOverComponents);
        EnableUIComonents(startOverComponents);
        scoreObject.SetActive(false);
    }

    public void EnableScore()
    {
        scoreObject.SetActive(true);
    }

    public void DisableStartUI()
    {
        DisableUIComonents(startOverComponents);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        EnableUIComonents(gameOverComponents);
        DisableUIComonents(startOverComponents);
    }

    private void DisableUIComonents(GameObject[] objectsToDisable)
    {
        foreach (GameObject obj in objectsToDisable)
        {
            obj.SetActive(false);
        }
    }
        private void EnableUIComonents(GameObject[] objectsToEnable)
    {
        foreach (GameObject obj in objectsToEnable)
        {
            obj.SetActive(true);
        }
    }

}