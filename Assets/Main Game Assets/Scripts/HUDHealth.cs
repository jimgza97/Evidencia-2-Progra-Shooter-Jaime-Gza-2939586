using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HUDHealth : MonoBehaviour {

    public static int iniHP;
    public int hp = 50;
    Text tHP;

    // Use this for initialization
    void Awake () {
        tHP = GetComponent<Text>();
        iniHP = hp;
    }
	
	// Update is called once per frame
	void Update () {
        tHP.text = "HP: " + iniHP;
        if (iniHP <= 0)
        {
            tHP.text = "HP: 0";
            SceneManager.LoadScene("Loser");
        }
    }
}
