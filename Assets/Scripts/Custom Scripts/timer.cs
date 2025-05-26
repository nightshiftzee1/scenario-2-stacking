using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    private float timeLeft = 15;
    public bool gameStarted = false;

    public GameObject victoryText;
    void Update()
    {
        if (gameStarted)
        {
            timeLeft -= Time.deltaTime;
        }

        if (timeLeft == 0 || timeLeft < 0)
        {
            victoryText.SetActive(true);
        }
    }

    public void StartTimer()
    {
        gameStarted = true;
    }
}