using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shattering : MonoBehaviour
{
    public GameObject originalstuff, shatterstuff;
    // Start is called before the first frame update
    private void OnMouseEnter()
    {
        Instantiate(shatterstuff, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(originalstuff);
            Instantiate(shatterstuff, originalstuff.transform.position, originalstuff.transform.rotation);
            this.gameObject.SetActive(false);
        }
    }

}
