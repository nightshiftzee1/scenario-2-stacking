using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;

    int score = 5;

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
            //Game over
        }
    }
    public void RemovePoint()
    {
        score -= 1;
        scoreText.text = score.ToString() + " POINTS";
    }
}
