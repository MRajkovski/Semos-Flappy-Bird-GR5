using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private GameObject gameOverCanvas;
    [SerializeField] private GameObject startCanvas;
    [SerializeField] private GameObject player;

    private Vector3 startPos;


    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        Time.timeScale = 0f;
    }
    void Start()
    {
        startPos = player.transform.position;
    }
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        player.transform.position = startPos;
        Score.instance.ResetScore();
        gameOverCanvas.SetActive(false);
        Time.timeScale = 1.0f;
        foreach (GameObject o in GameObject.FindGameObjectsWithTag("Obstacle"))
        {
            Destroy(o);
        }
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void StartGame()
    {
        Time.timeScale = 1.0f;
        startCanvas.SetActive(false);
        player.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
}
