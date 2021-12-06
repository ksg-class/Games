
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class AllSounds 
{
    public string name;

    public AudioMixer am;

    public AudioClip clip;

    [Range(0f,1f)]
    public float volume;

    public bool loop;

    public AudioSource source;
}
