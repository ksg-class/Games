using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOff : MonoBehaviour
{
    public Transform p;
    public Vector3 off;
    public float speed;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = p.position + off;
    }
    private void Update()
    {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        transform.Rotate(Vector3.up * x * speed * Time.deltaTime - Vector3.right * y * speed * Time.deltaTime);
    }
}
