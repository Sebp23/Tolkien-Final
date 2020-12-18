using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public static void playButton()
    {
        //loads help scene
        SceneManager.LoadScene("HelpMenu");
    }

    public static void quitButton()
    {
        //exits game
        Application.Quit(0);
    }

    public static void startGame()
    {
        //loads the game scene
        SceneManager.LoadScene("GameScene");
    }
}
