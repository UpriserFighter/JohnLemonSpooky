using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TimeLimit : MonoBehaviour
{
    public float currentTime;
    public TextMeshProUGUI timeText;
    public GameObject gE;

    // Start is called before the first frame update
    void Start()
    {
        //set time limit in seconds
        currentTime = 60f;

        gE = GameObject.Find("GameEnding");
    }

    // Update is called once per frame
    void Update()
    {
        //update time
        if (currentTime >= 0) //timer stops after it passes 0
        {
            currentTime -= Time.deltaTime;
        }

        timeText.text = "" + (Mathf.Round(currentTime)); //display remaining time as rounded float

        //if time reaches 0, game over!
        if (currentTime <= 0)
            {
            gE.GetComponent<GameEnding>().CaughtPlayer();
        }
    }
}
