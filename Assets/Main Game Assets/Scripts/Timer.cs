using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public static float time;
    public float timeLimit = 60.0f;
    Text tTimer;

    void Awake()
    {
        tTimer = GetComponent<Text>();
        time = timeLimit;          //Reset score so that every new game doesnt start with last time's score
    }

    void Update()
    {
        time -= Time.deltaTime;
        tTimer.text = "Time left: " + Mathf.Round(time);
        if(time <= 0)
        {
            SceneManager.LoadScene("Winner");
        }
    }
}