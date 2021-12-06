using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Sound : MonoBehaviour
{
    public AllSounds s;
    public Slider mval, sfxval;
    public AudioSource music;
    public AudioMixer mm,sm;
    
    // Start is called before the first frame update
    void Start()
    {
        mval.value = PlayerPrefs.GetFloat("MusicVolume");
        sfxval.value = PlayerPrefs.GetFloat("SFXVolume");
        AudioListener.volume = 1;
        //DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        music.volume = mval.value;
        
    }
    public void SoundPrefs()
    {
        PlayerPrefs.SetFloat("MusicVolume", mval.value);
        PlayerPrefs.SetFloat("SFXVolume", sfxval.value);
    }
    
    
}
