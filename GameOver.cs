using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public UnityEngine.UI.Text score;


    private void Start()
    {
        score.text = "Score: "+ GameObject.FindObjectOfType<Score>().GetComponent<Score>().Score_get();
    }


    
}
