using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonManager : MonoBehaviour {

	public void NewGamePress(string newGameLevel)       //Start game
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void ExitGamePress()                         //Exit game
    {
        Application.Quit();
    }

    public void GoMainMenu(string menuScene)            //Returns to main menu screen
    {
        SceneManager.LoadScene(menuScene);
    }

    public void GoInstructions(string instruc)          //How to play screen
    {
        SceneManager.LoadScene(instruc);
    }

    public void GoWinner(string winrar)                 //Game over (Win) screen
    {
        SceneManager.LoadScene(winrar);
    }

    public void GoLoser(string loser)                   //Game over (Win) screen
    {
        SceneManager.LoadScene(loser);
    }
}
