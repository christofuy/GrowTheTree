using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameProperties : MonoBehaviour
{
    public string lvl1;
    public string mainmenu;
    public string howtoplay;
    public string gameover;
    public string winscreen;

    private PlayerHealthBar playerhealthbar;

    private void Start()
    {
    }

    public void LoadMainMenu()
    {
        SoundManager.PlaySound("select");
        SceneManager.LoadScene(mainmenu);
    }

    public void StartGame()
    {
        SoundManager.PlaySound("select");
        SceneManager.LoadScene(lvl1);
    }

    public void LoadHowToPlay()
    {
        SoundManager.PlaySound("select");
        SceneManager.LoadScene(howtoplay);
    }

    public void GameOver()
    {
        SceneManager.LoadScene(gameover);
        SoundManager.PlaySound("gameover");
    }

    public void WinScreen()
    {
        SceneManager.LoadScene(winscreen);
    }

    public void QuitGame()
    {
        SoundManager.PlaySound("select");
        Application.Quit();
        Debug.Log("Quitting...");
    }
}
