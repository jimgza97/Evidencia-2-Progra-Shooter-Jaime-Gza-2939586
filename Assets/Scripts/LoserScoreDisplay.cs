using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LoserScoreDisplay : MonoBehaviour
{
    Text tScoreW;

    void Awake()
    {
        tScoreW = GetComponent<Text>();
    }

    void Update()
    {
        tScoreW.text = "Your lame score: " + HUD.score;
    }
}