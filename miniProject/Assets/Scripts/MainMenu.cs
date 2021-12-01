using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public GameObject MenuMusic;
    public static bool MusicStart = false;
    public AudioSource menumusic;

    private void Start()
    {
        if (MusicStart)
        {
            MenuMusic.SetActive(false);
        }
        else
        {
            MenuMusic.SetActive(true);
        }
        menumusic.volume = PlayerPrefs.GetFloat("MusicVolume");
    }
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exited");
    }
}
