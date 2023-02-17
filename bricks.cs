using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bricks : MonoBehaviour
{
    public Sprite[] brickSprite;
    public static int totalBricks;
    private int maxHit;
    private int Hitcount;
    private Score scoreScript;
    public AudioClip HitSound;
    public AudioClip destroySound;
    public GameObject crash;



    void Start()
    {
        maxHit = brickSprite.Length + 1;
        totalBricks++;
        scoreScript = GameObject.FindObjectOfType<Score>().GetComponent<Score>();
    }

    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D t)
    {
        if (t.gameObject.name.Equals("ball"))
        {
            scoreScript.Score_increase();
            Hitcount++;


            if (Hitcount >= maxHit)
            {
                totalBricks--;
                if (totalBricks <= 0)
                {
                    GameObject.FindObjectOfType<GameMechanics>().GetComponent<GameMechanics>().NextScene();

                }
                Vector3 pos = t.contacts[0].point;
                GameObject go = Instantiate(crash, pos, Quaternion.identity) as GameObject;
                Color brickcolor = GetComponent<SpriteRenderer> ().color;
                go.GetComponent<ParticleSystemRenderer> ().material.color = brickcolor;

                Destroy(go, 1f);
                AudioSource.PlayClipAtPoint(destroySound, transform.position);
                Destroy(gameObject);
            }

            else
            {
                AudioSource.PlayClipAtPoint(HitSound, transform.position);
                GetComponent<SpriteRenderer>().sprite = brickSprite[Hitcount - 1];
            }

        }

    }

  
}
