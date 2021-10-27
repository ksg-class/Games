using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField] 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (DieCondition(collision))
        {
            Die();
        }
    }
    bool DieCondition(Collision2D collision)
    {
        BirdMove theBird = collision.gameObject.GetComponent<BirdMove>();
        if (theBird != null)
        {
            return true;
        }
        return false;
    }
    void Die()
    {
        gameObject.SetActive(false);
    }
}
