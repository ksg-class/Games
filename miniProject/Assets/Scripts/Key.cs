using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public Component trigger;

    private void Update()
    {
        this.gameObject.transform.Rotate(0f, 0.1f, 0f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            trigger.GetComponent<BoxCollider>().enabled = true;
            this.gameObject.SetActive(false);
        }
    }
}
