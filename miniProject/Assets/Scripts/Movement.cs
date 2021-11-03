using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour{

	public Rigidbody rb;
	public float f=500;
	public float s=10;
	
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("LULW");
        //rb.AddForce(0,100,0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.AddForce(0,0,f*Time.deltaTime);
        
        if(Input.GetKey("d")){
        	rb.AddForce(s*Time.deltaTime,0,0,ForceMode.VelocityChange);
    	}
    	if(Input.GetKey("a")){
        	rb.AddForce(-s*Time.deltaTime,0,0,ForceMode.VelocityChange);
    	}
        if (Input.GetKey("w"))
        {
            rb.AddForce( 0, 0, s * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -s * Time.deltaTime, ForceMode.VelocityChange);
        }
        /*if (rb.position.y<-2){
    		FindObjectOfType<GameManager>().end();
    	}*/
    }
}
