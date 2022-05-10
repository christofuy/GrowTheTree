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

    private void Start()
    {
        //SceneManager.LoadScene("MainMenu");
    }

    public void StartGame()
    {
        SceneManager.LoadScene(lvl1);
    }

    public void LoadHowToPlay()
    {
        SceneManager.LoadScene(howtoplay);
    }

    public void GameOver()
    {
        SceneManager.LoadScene(gameover);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting...");
    }
}
