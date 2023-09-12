using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoForce : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector2 rba;
    // Start is called before the first frame update
    void Start()
    {
        rba.x = 0;
    }

    // Update is called once per frame
    void Update()
    {

        rb.velocity = rba;
    }
}
