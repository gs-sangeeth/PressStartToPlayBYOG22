using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
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
        if((mousePosition.x >= (centre.position.x - centre.localScale.x))&& (mousePosition.x <= (centre.position.x + centre.localScale.x)))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
        else if(mousePosition.x > transform.position.x)
        {
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, 0);
        }
        else if (mousePosition.x < transform.position.x)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2( -moveSpeed, 0);
        }
            
    }
}
