using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOff : MonoBehaviour
{
    public Transform p;
    public Vector3 off;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = p.position + off;
    }
}
