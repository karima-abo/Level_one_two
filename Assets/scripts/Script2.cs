using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    private Rigidbody2D rg;
    public float jump;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") )
        {
            rg.velocity = new Vector2(rg.velocity.x, jump);

        }
    }
}
