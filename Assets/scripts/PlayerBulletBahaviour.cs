using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletBahaviour : MonoBehaviour
{
    private Rigidbody2D rb;
    private float bulletSpeed = 100;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector2.right * bulletSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "enemy"|| collision.tag == "block")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (collision.tag == "ground"|| collision.tag == "attac")
        {
            Destroy(gameObject);
        }
    }
}
