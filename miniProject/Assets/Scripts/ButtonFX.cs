using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFX : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource button;
    public AudioClip hover, click;

    public void hoverFX()
    {
        button.PlayOneShot(hover);
    }
    public void clickFX()
    {
        button.PlayOneShot(click);
    }
}
