using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uivansih : MonoBehaviour
{
    public GameObject UITEXT;
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

            UITEXT.SetActive(false);


        }



        }

}