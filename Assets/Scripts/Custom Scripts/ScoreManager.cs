using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;

    int score = 5;

    public GameObject MainScene;
    public GameObject GameOverScreen;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = score.ToString() + " POINTS";
    }

    private void Update()
    {
        if (score == 0 || score < 0)
        {
            MainScene.SetActive(false);
            GameOverScreen.SetActive(true);
            score = 5;
        }
    }
    public void RemovePoint()
    {
        score -= 1;
        scoreText.text = score.ToString() + " POINTS";
    }
}
