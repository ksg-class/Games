using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Paused : MonoBehaviour
{
    public static bool pauseState = false;
    public GameObject pauseUI;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseState)
                Resume();
            else
                Pause();
        }
    }
    public void Pause()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        pauseState = true;
    }
    public void Resume()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        pauseState = false;
    }
    public void ShowOptions()
    {
        Debug.Log("Options menu");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("miniProj1");
        Debug.Log("Main menu");
    }
}
