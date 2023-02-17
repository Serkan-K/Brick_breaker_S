using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borders : MonoBehaviour
{
    public AudioClip borderSound;
    public GameObject hit;


    void OnCollisionEnter2D(Collision2D d)
    {
        AudioSource.PlayClipAtPoint(borderSound, transform.position);
        Vector3 pos = d.contacts[0].point;
        GameObject go = Instantiate(hit, pos, Quaternion.identity) as GameObject;
        Destroy(go, 1f);
    }
}
