using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOver : MonoBehaviour
{
    public Text points;

    void Start(){
        gameObject.SetActive(false); 
    }

    public void setup(int score)
    {
    	  gameObject.SetActive(true);   
        points.text = "Score: " + score.ToString() + " POINTS";
    }

}
