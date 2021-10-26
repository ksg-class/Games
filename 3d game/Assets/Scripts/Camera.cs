using UnityEngine;

public class Camera : MonoBehaviour
{
	public Transform p;
	public Vector3 off;
	
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position=p.position+off;
    }
}
