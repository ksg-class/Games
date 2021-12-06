using System.Collections;
using System;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AllSounds[] sounds;
    void Awake()
    {
        foreach (AllSounds s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;

            s.source.loop = s.loop;
        }
    }
    private void Start()
    {
        FindObjectOfType<AudioManager>().Play("MenuMusic");
    }
    public void Play(string name)
    { 
        AllSounds s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
}
