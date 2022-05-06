using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public GameObject title;
    public bool isStart = false;
    private GameObject button;

    private void Start()
    {
        button = GameObject.Find("PlayButton");
        title = GameObject.Find("TitleText");
    }

    //This class is for things such as controlling what stage/wave you are on, things like game overs, etc


    //public void PlayGame()
    //{
    //SceneManager.LoadScene("GrowTheTree");
    //}

    void ButtonClicked()
    {
        button.SetActive(false);
        title.SetActive(false);
    }
}
