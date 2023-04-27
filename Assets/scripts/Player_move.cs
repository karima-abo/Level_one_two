using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_move : MonoBehaviour
{
    private Rigidbody2D rg;
    private Animator anim;
    public float speed;
    private float move;
    private SpriteRenderer sp;
    private float x;
    public float jump;
    private BoxCollider2D coll;
    public LayerMask onejump;
    private enum PlayerState { idel, running, jumping };
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement();
        UpdateAnimatain();

    }




    void movement()
    {


        x = Input.GetAxisRaw("Horizontal");
        move = x * speed;
        rg.velocity = new Vector2(move, rg.velocity.y);

        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            rg.velocity = new Vector2(rg.velocity.x, jump);

        }
    }

    void UpdateAnimatain()
    {
        PlayerState state;

        if (x > 0f)
        {
            state = PlayerState.running;
            sp.flipX = false;
        }
        else if (x < 0f)
        {
            state = PlayerState.running;
            sp.flipX = true;
        }
        else
        {
            state = PlayerState.idel;
        }
        if (rg.velocity.y > .1f)
        {
            state = PlayerState.jumping;

        }


        anim.SetInteger("state", (int)state);
    }

    private bool isGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, 0.1f, onejump);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "trans")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "attac")
        {
            Debug.Log("game over");
        }
    }
}