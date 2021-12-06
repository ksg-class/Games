using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider healthbar;

    public void MaxHealth(int health)
    {
        healthbar.maxValue = health;
        healthbar.value = health;
    }
    public void CurrentHealth(int health)
    {
        healthbar.value = health;
    }
    
}
