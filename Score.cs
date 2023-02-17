using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score;
    
    
    
    
    public void Score_increase()
    {
        score+=100;
    }

    public int Score_get()
    {
        return score;
    }

    public void ScoreReset()
    {
        score = 0;
    }

}
