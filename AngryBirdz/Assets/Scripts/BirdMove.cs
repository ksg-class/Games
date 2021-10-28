using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour
{
    Vector2 posi;
    [SerializeField] float speed = 5.0f;
    [SerializeField] float delay = 2f;
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
        Vector2 mouseposi = mouse;

        if (mouseposi.x > posi.x)
        {
            mouseposi.x = posi.x;
        }
        
        
        //transform.position = new Vector3(mouse.x, mouse.y, transform.position.z);
        
    }
    // Update is called once per frame
    
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(BirbDelay());
        
        
    }
    IEnumerator BirbDelay()
    {
        yield return new WaitForSeconds(delay);
        birb.position = posi;
        birb.isKinematic = true;
        birb.velocity = new Vector2(0, 0);
    }
}
