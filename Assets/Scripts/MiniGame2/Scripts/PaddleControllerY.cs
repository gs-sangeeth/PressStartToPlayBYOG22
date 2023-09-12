using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControllerY : MonoBehaviour
{
  public float moveSpeed;
  public Transform centre;
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
    // if((mousePosition.y >= (centre.position.y - centre.localScale.y))&& (mousePosition.y <= (centre.position.y + centre.localScale.y)))
    // {
    //     GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    // }
    if(mousePosition.y > transform.position.y)
    {
    GetComponent<Rigidbody2D>().velocity = new Vector2(0, moveSpeed);
    }
    else if (mousePosition.y < transform.position.y)
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -moveSpeed);
    }



    }
}
