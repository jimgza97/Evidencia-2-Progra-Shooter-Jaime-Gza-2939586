using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public static int score;
    Text tScore;

    void Awake()
    {
        tScore = GetComponent<Text>();
        score = 0;          //Reset score so that every new game doesnt start with last time's score
    }

    void Update()
    {
        tScore.text = "Score: " + score;
    }
}