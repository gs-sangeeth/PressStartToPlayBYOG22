using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DragStuff : MonoBehaviour
{
    public Vector3 newPos;
    public Vector3 OffPos;

    private void Start()
    {
        AudioManager.instance.Play("platformerTheme");
    }

    public void FixedUpdate()
    {
      //  OnMouseDrag();
    }
    public Vector3 GetMouseWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x * 0.7f, Input.mousePosition.y * 0.7f,0));
    }

    public void OnMouseDown()
    {


        OffPos = gameObject.transform.position - GetMouseWorldPosition();
    }


    public void OnMouseDrag()
    {
        

        transform.position = ( GetMouseWorldPosition()  + OffPos);
    }

   
}

