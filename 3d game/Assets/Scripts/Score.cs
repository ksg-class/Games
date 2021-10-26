using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform t;
	public Text score;
    // Update is called once per frame
    void Update()
    {
       score.text=((t.position.z)/10).ToString("0");
    }
}
