using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public GameObject heartOne;
    public GameObject heartTwo;
    public GameObject heartThree;

    public GameObject[] hearts;


    public int heartCtr;
    public int obstacleCtr;

    public int health = 3;

    public bool check;



    //public GameObject Hearts;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        for ( int i = 0; i < hearts.Length; i++)
        {

            if ( health < 0 )
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

            for ( int j = 0; j < health; j--  )
            {

            }


        }







        check = Hearts.isHeart;

       // check = false;

        heartCtr = Hearts.Heartcounter;
        obstacleCtr = obstacle.counter;

        if ( health < -1 )
        {

            // Reload Level
        }

        if (obstacleCtr > 3)
        {
            // reload level

            
        }

        if (obstacleCtr == 1)
        {
            // setactive 1 heart false
            heartOne.SetActive(false);

            health = health - 1;

        }

     


        if (obstacleCtr == 2)
        {
            // setactive 1 heart false
            heartTwo.SetActive(false);

            health = health - 1;

        }

        if (obstacleCtr == 3)
        {
            // setactive 1 heart false
            heartThree.SetActive(false);

            health = health - 1;

        }

        if (Hearts.isHeart == true)
        {

            heartOne.SetActive(true);
            heartOne.SetActive(true);
            heartOne.SetActive(true);

        }

      //  if ( )










    }
}
