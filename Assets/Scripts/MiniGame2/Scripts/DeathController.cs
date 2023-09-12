using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathController : MonoBehaviour
{
    public Transform newBall, spawnPoint;

    void OnTriggerEnter2D(Collider2D c)
    {
      if(c.tag == "ball")
      {

        Instantiate(newBall, spawnPoint);
        //GameObject.Find("wholeBrick").GetComponent<AudioSource>().Play();
        Destroy(c.gameObject);

        GameObject.Find("Hearts").GetComponent<Lives>().Died();
      }
      if(c.tag == "play area")
      {
        c.transform.position = new Vector3(0f, 0f, 0f);
      }
    }
}
