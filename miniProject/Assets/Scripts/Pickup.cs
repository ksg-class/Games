using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] GameObject thisonelol;
    // Start is called before the first frame update
    private void Update()
    {
        this.gameObject.transform.Rotate(0f, 0.1f, 0f);
    }
    private void OnCollisionEnter(Collision col)
    {

        StartCoroutine(RespawnDelay());
       
    }
    IEnumerator RespawnDelay()
    {
        thisonelol.SetActive(false);

        yield return new WaitForSeconds(2);

        thisonelol.SetActive(true);

    }
}
