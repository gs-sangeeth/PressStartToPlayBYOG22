using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearts : MonoBehaviour
{
    public GameObject player;

    public static int Heartcounter;

    public static bool isHeart;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
          //  Debug.Log("hello");

            isHeart = true;

            // Heartcounter = Heartcounter + 1;

            obstacle.counter = obstacle.counter - 1;

            MG1Manager.instance.CollectPowerUp();

            AudioManager.instance.Play("platformerHeart");

            // Object.Destroy(this.gameObject);
            // this.gameObject.SetActive(false);
            Destroy(gameObject);

        }

        isHeart = false;


        
    }

}
