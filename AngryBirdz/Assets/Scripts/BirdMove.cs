﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour
{
    Vector2 posi;
    [SerializeField] float speed = 5.0f;
    Rigidbody2D birb;

    // Start is called before the first frame update
    void Awake()
    {
        birb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
       posi = birb.position;
       birb.isKinematic = true;
    }

    void OnMouseDown()
    {
       GetComponent<SpriteRenderer>().color = Color.gray;
    }
    void OnMouseUp()
    {
        var curPosi = birb.position;
        Vector2 direction =  -curPosi + posi;
        direction.Normalize();
        GetComponent<SpriteRenderer>().color = Color.white;

        birb.isKinematic = false;
        birb.AddForce(direction * speed);
    }
    void OnMouseDrag()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mouse.x, mouse.y, transform.position.z);
        
    }
    // Update is called once per frame
    
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        birb.position = posi;
        birb.isKinematic = true;
        birb.velocity = new Vector2(0,0);
        
    }
}
