using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform enemyR,enemyG, player;
    public Text timescore, prevScores;
    float ts;
    string scoress = "";
    // Update is called once per frame
    void Update()
    {
        if(enemyR.transform.position != player.transform.position && enemyG.transform.position != player.transform.position)
        {
            ts += Time.deltaTime;
            
        }
        else
        {
            ts = Mathf.RoundToInt(ts);
            if(ts!=0)
                scoress =  ts.ToString() + "\n" + scoress;
            prevScores.text = scoress;
            ts = 0;
        }
        
        /*for(int j = 0; j < 5; j++)
        {
            scoress += scores[i] + "\n";
        }*/
        timescore.text = ts.ToString("0");
        //prevScores.text = scoress;
        //timescore.text = scoress;
        //timescore.text = ts.ToString("0");
    }
}
