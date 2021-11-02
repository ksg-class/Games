using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public Transform player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*float mx = Input.GetAxis("Horizontal");
        float mz = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(Mathf.Clamp(mx*speed*Time.deltaTime, -1.8f, 1.8f), 0, Mathf.Clamp(mz * speed * Time.deltaTime, -9.8f, 9.8f));

        transform.Translate(movement);*/



        if (Input.GetAxis("Horizontal") != 0)
        {

            transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);

        }
        
        if (Input.GetAxis("Vertical") != 0)
        {
            transform.position += new Vector3(0,0,Input.GetAxis("Vertical") * speed * Time.deltaTime);
        }

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -19.8f, 19.8f), transform.position.y, Mathf.Clamp(transform.position.z, -19.8f, 19.8f));
    }
}
