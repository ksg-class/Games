using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    int MaxHealth = 100, currenthealth;
    public int stayDamage = 1;
    private Health health;
    public Slider healthbar;
    // Start is called before the first frame update
    void Start()
    {
        currenthealth = MaxHealth;
        MaxiHealth(MaxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(currenthealth <= 0)
        {
            this.gameObject.SetActive(false);
            StartCoroutine(RestartScene());
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            TakeDamage(10);
        }
        if(col.gameObject.tag == "HealthRegen")
        {
            Regen(60);
        }
    }
    void TakeDamage(int damage)
    {
        currenthealth -= damage;
        CurrentHealth(currenthealth);
    }
    private void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            TakeDamage(stayDamage);
        }
    }
    void Regen(int regen)
    {
        currenthealth += regen;
        if (currenthealth > 100)
        {
            currenthealth = 100;
        }
        CurrentHealth(currenthealth);
    }

    IEnumerator RestartScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void MaxiHealth(int health)
    {
        healthbar.maxValue = health;
        healthbar.value = health;
    }
    public void CurrentHealth(int health)
    {
        healthbar.value = health;
    }
}
