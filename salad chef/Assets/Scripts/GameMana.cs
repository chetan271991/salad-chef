using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMana : MonoBehaviour
{
    public Text Timer;
    public static float currentTimer;
    public Text WinText;

    private void Start()
    {
        currentTimer = 120f;
        WinText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        currentTimer -= Time.deltaTime;
        if (currentTimer >= 0)
        {
            Timer.text = currentTimer.ToString("0");
        }
        else Timer.text = "0";
        if (currentTimer <= 0)
        {
            WinText.gameObject.SetActive(true);
            if (Player1Movement.score > Player2Movement.score)
            {
                WinText.text = "Player 1 WON";
            }
            if (Player2Movement.score > Player1Movement.score)
            {
                WinText.text = "Player 2 WON";
            }
            if(Player1Movement.score == Player2Movement.score)
            {
                WinText.text = "DRAW";
            }

        }
    }
}
