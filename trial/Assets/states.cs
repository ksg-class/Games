using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class states : MonoBehaviour
{
    public Transform[] points;
    int lastpoint, targetpoint = 0;
    public Transform target, player;
    public float speed,att, rot, range1, range2;
    public enum EnemyStates
    {
        walk, attack, idle
    }
    public EnemyStates es;
    // Start is called before the first frame update
    void Start()
    {
        lastpoint = points.Length - 1;
        target = points[targetpoint];
    }

    // Update is called once per frame
    void Update()
    {
        float rangee = Vector3.Distance(transform.position, player.transform.position);
        if (rangee < range1)
        {
            es = EnemyStates.attack;
        }

        switch (es)
        {
            case EnemyStates.idle:
                Debug.Log("Idle LUL");
                break;
            case EnemyStates.walk:
                Vector3 waydir = target.position - transform.position;
                Quaternion rotdir = Quaternion.LookRotation(waydir);
                transform.rotation = Quaternion.Slerp(transform.rotation, rotdir, rot * Time.deltaTime);
                if (transform.position == target.position)
                {
                    targetpoint++;
                    if (targetpoint > lastpoint)
                        targetpoint = 0;
                    target = points[targetpoint];
                }
                transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
                break;
            case EnemyStates.attack:
                Vector3 waydira = player.transform.position - transform.position;
                Quaternion rotdira = Quaternion.LookRotation(waydira);
                transform.rotation = Quaternion.Slerp(transform.rotation, rotdira, rot * Time.deltaTime);
                transform.position = Vector3.MoveTowards(transform.position, player.transform.position, att*speed * Time.deltaTime);
                break;
            

        }
        if (rangee > range2)
        {
            es = EnemyStates.walk;
        }
        if (rangee == 0)
        {
            es = EnemyStates.idle;
        }
        
    }
}
