using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecredit : MonoBehaviour
{
    private Vector2 respawn;
    public GameObject bottom;
    private void Start()
    {
        respawn = bottom.transform.position;
    }
    void FixedUpdate()
    {
        transform.Translate(0, 2.5f * Time.deltaTime, 0);
        //Debug.Log(respawn);
        if (transform.position.y >= 10)
        {
            Debug.Log("hello");

            transform.position = respawn;
        }
    }
   
  
}
