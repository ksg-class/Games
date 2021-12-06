using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SFX : MonoBehaviour
{
    public AudioMixer sfx,music;
    // Start is called before the first frame update
    private void Start()
    {
        AudioListener.volume = 1;
        DontDestroyOnLoad(this.gameObject);
    }
    public void SetMusicMixer(float musicvolume)
    {
        music.SetFloat("MusicVol", Mathf.Log10(musicvolume) * 20);
    }
    public void SetMixer(float sfxvolume)
    {
        sfx.SetFloat("SFXVol", Mathf.Log10(sfxvolume) * 20);
    }
}
