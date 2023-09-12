using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickStat : MonoBehaviour
{
    public int health, currentHealth;

    void Start()
    {
      currentHealth = health;
    }

    public void Hit()
    {
      currentHealth--;
      Color tmp = GetComponent<SpriteRenderer>().color;
      tmp.a -= tmp.a/health;
      GetComponent<SpriteRenderer>().color = tmp;

      if(currentHealth == 0)
      {
        GameObject.Find("Hearts").GetComponent<Lives>().ReduceBrick();
        Destroy(this.gameObject);
      }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        BallController ball = collision.gameObject.GetComponent<BallController>();

        if(ball != null)
        {
            Hit();
        }

    }
}
