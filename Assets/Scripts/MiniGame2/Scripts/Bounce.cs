using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float bounceStrength;

    void Start()
    {
      bounceStrength = 250f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        BallController ball = collision.gameObject.GetComponent<BallController>();

        if(ball != null)
        {
            //GetComponent<AudioSource>().Play();
            Vector2 normal = collision.GetContact(0).normal;
            // normal.x += Random.Range(-0.15f, 0.15f);
            // normal.y += Random.Range(-0.15f, 0.15f);
            ball.Bounce(-normal * bounceStrength);
        }

    }
}
