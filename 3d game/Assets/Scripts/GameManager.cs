using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameend = false;
   
    public void end(){
    
    	if (gameend == false){
			 gameend=true;
			 Debug.Log("End");
			 Invoke("Restart",1.5f);
		}

}
	void Restart(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}	
   
}
