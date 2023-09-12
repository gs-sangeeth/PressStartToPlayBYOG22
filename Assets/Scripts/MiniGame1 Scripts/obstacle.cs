using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class obstacle : MonoBehaviour
{
    public GameObject player;
    Vector2 respawn;
   // public Text HealthCount;
    //public string tempCount;

    public static int counter ;

    private void Start()
    {
        respawn = player.transform.position;
        counter = 0;

        
    }

    private void Update()
    {
        Debug.Log(respawn);

        //tempCount = counter.ToString();
       // HealthCount.text  = tempCount;
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("hello");
            player.transform.position = respawn;
            MG1Manager.instance.Hit();
            counter = counter + 1;

           AudioManager.instance.Play("platformerObs");

            CameraShake.instance.Shake(0.5f,0.25f);

        }

    }

}
