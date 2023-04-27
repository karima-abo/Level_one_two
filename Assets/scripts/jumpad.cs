using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpad : MonoBehaviour
{
    public float jump = 15f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jump, ForceMode2D.Impulse);
        }
    }
}
