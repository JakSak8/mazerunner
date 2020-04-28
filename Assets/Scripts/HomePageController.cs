using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomePageController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKeyDown("1"))
        // {
        //     Play();
        // }

        // if(Input.GetKeyDown("2"))
        // {
        //     Leaderboard();
        // }

        // if(Input.GetKeyDown("3"))
        // {
        //     Quit();
        // }
    }

    void Start()
    {
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Play()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Leaderboard()
    {
        SceneManager.LoadScene("Leaderboard");
    }
}
