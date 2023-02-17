using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    public AudioClip paddleSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 MousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,50f));
        transform.position = new Vector3(Mathf.Clamp(MousePos.x,-7.8f,7.5f), transform.position.y, transform.position.z);
    }

    void OnCollisionEnter2D(Collision2D d)
    {
        AudioSource.PlayClipAtPoint(paddleSound, transform.position);
    }
}
