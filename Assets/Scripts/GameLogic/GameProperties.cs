using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameProperties : MonoBehaviour
{
    public string lvl1;

    private void Start()
    {
        //SceneManager.LoadScene(lvl1);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(lvl1);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting...");
    }
}
