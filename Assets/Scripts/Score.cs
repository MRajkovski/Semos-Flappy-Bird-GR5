using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score instance;

    [SerializeField] private TextMeshProUGUI currentScoreText;
    [SerializeField] private TextMeshProUGUI highScoreText;

    private int score;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        currentScoreText.text = score.ToString();
        highScoreText.text = PlayerPrefs.GetInt("HighScore",0).ToString();
        UpdateHighScore();
    }
    public void ResetScore()
    {
        score = 0;
        currentScoreText.text = score.ToString();
    }
    private void UpdateHighScore()
    {
        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScoreText.text = score.ToString();
        }
    }

    public void UpdateScore()
    {
        score++;
        currentScoreText.text = score.ToString();
        UpdateHighScore();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
