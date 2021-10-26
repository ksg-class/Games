using UnityEngine;

public class Collision : MonoBehaviour
{
public Movement M;
    
    void OnCollisionEnter(UnityEngine.Collision co){
    
   	if(co.gameObject.tag=="Obstacle"){
   	Debug.Log("LULW");
   	M.enabled=false;
   	FindObjectOfType<GameManager>().end();
   }
}
}
