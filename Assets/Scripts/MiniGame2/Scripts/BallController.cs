using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float startX, startY, moveSpeed, addition, increment;
    Rigidbody2D rb;

    public AudioSource normalCollision, brickHit, death;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 direction = new Vector2(startX, startY);
        rb.AddForce(direction * moveSpeed);

    }

    public void Bounce(Vector2 direction)
    {
        rb.AddForce(direction * addition);
        //addition += increment;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.gameObject);


        if (collision.gameObject.GetComponent<BrickController>() != null)
        {
            brickHit.Play();
        }
        else if (collision.gameObject.GetComponent<Bounce>() != null)
        {
            CameraShake.instance.Shake(.5f, .25f);
            normalCollision.Play();
        }
        else if (collision.gameObject.GetComponent<DeathController>() != null)
        {
            death.Play();
        }
    }
}
