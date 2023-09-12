using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : MonoBehaviour
{
    public Transform centre, centreY;
    public float moveSpeed;
    Vector2 currentPosition;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);


        //if ((mousePosition.x > left.position.x) && (mousePosition.x < right.position.x))
        //{
        //    transform.position = Vector2.Lerp(transform.position, new Vector2(mousePosition.x, this.transform.position.y), moveSpeed);
        //}
        if ((mousePosition.x >= (centre.position.x - centre.localScale.x)) && (mousePosition.x <= (centre.position.x + centre.localScale.x)))
        {
            currentPosition = Vector2.zero;
        }
        else if (mousePosition.x > transform.position.x)
        {
            currentPosition = new Vector2(moveSpeed, 0);
        }
        else if (mousePosition.x < transform.position.x)
        {
            currentPosition = new Vector2(-moveSpeed, 0);
        }

        if ((mousePosition.y >= (centreY.position.y - centreY.localScale.y)) && (mousePosition.y <= (centreY.position.y + centreY.localScale.y)))
        {
            currentPosition = new Vector2(currentPosition.x, 0);
        }
        else if (mousePosition.y > transform.position.y)
        {
            currentPosition = new Vector2(currentPosition.x, moveSpeed);
        }
        else if (mousePosition.y < transform.position.y)
        {
            currentPosition = new Vector2(currentPosition.x, -moveSpeed);
        }
        //Debug.Log(mousePosition.y + " - " + transform.position.y);
        GetComponent<Rigidbody2D>().velocity = currentPosition * Time.deltaTime;
    }
    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //   Debug.Log("Hit");
    //     BrickStat ball = collision.gameObject.GetComponent<BrickStat>();
    //
    //     if(ball != null)
    //     {
    //         ball.Hit();
    //     }
    //
    // }
}
