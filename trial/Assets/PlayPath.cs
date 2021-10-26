using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPath : MonoBehaviour
{
    public Transform[] points;
    int lastpoint, targetpoint=0;
    public Transform target;
    public float speed, rot;
    void Start()
    {
        lastpoint = points.Length - 1;
        target = points[targetpoint];

    }
    void Update()
    {
        Vector3 waydir = target.position - transform.position;
        Quaternion rotdir = Quaternion.LookRotation(waydir);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotdir, rot * Time.deltaTime);
        if(transform.position == target.position)
        {
            targetpoint++;
            if (targetpoint > lastpoint)
                targetpoint = 0;
            target = points[targetpoint];
        }
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

}
