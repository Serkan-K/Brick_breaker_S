using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    private GameMechanics brick_adet;

    public void Start()
    {
        
    }

    public void digersahne()
    {
        bricks.totalBricks = 0;
        GameObject.FindObjectOfType<Score>().GetComponent<Score>().ScoreReset();
        SceneManager.LoadScene("ana_ekran");
        
    }


    
}
