using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Sound : MonoBehaviour
{
    public AudioMixer mv, sv;
   
    public void Volume (float vol)
    {
        Debug.Log(vol);
        mv.SetFloat("MusicVol", vol);       
        sv.SetFloat("SFXVolume", vol);
    }
}
