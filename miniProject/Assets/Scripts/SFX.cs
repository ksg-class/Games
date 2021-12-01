using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SFX : MonoBehaviour
{
    public AudioMixer sfx;
    // Start is called before the first frame update
   
    public void SetMixer(float sfxvolume)
    {
        sfx.SetFloat("SFXVol", Mathf.Log10(sfxvolume) * 20);
    }
}
