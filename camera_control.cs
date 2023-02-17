using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_control : MonoBehaviour
{
    private Vector3 firstPos;


    private void Start()
    {
        firstPos = transform.position;
        transform.position = new Vector3(firstPos.x, firstPos.y+10f, firstPos.z);
    }


    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, firstPos, 1.5f * Time.deltaTime);
    }
}
