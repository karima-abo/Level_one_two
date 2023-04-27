using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacar : MonoBehaviour
{
    public GameObject[] border;
    public float speed = 3f;
    private  int CurrentPointIndex=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   private  void Update()
    {
        if (Vector2.Distance(border[CurrentPointIndex ].transform.position, transform.position) < 0.1f)
        {
            CurrentPointIndex++;
            if (CurrentPointIndex  >=  border.Length)
            {
                CurrentPointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, border[CurrentPointIndex ].transform.position, Time.deltaTime * speed);
    }
}
