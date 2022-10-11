using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    
    public TMP_Text someText;
   

    public float pointIncreasedPerSecond;
    public float score, highscore;

    public bool scoreIncreasing;


  
    // Start is called before the first frame update
    void Start()
    {
        score = 0f;
        pointIncreasedPerSecond = 10f; 

    }

    // Update is called once per frame
    void Update()
    {
        if (scoreIncreasing)
        {
            score += pointIncreasedPerSecond * Time.deltaTime;
           
        }

        if (score > highscore) {
            highscore = score;
        }

        someText.text = " Score:" + (int)score;
        
    }

    


}
