using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update
    private bool movingLeft;
    void Start()
    {
        movingLeft = true;
    }
    void Update()
    {
        if (movingLeft == true)
        {
            // move left
            if (transform.position.x <= -4) movingLeft = false;
        }
        else
        {
            // move right
        }
    }
}
