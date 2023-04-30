using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyBulletBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] GameObject player;
    private float bulletSpeed = 200;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector3 direction = player.transform.position - transform.position;
        rb.AddForce(Vector2.left * bulletSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" )
        {
            Destroy(gameObject);
        }
        if (collision.tag == "PlayerBullet" )
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
        }
    }
}
