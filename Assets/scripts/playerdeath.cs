using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerdeath : MonoBehaviour
{
    private Rigidbody2D rg;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("attac") )
        { Die(); }
        
    }


    private void Die()
    {
        anim.SetTrigger("Death");
        rg.bodyType = RigidbodyType2D.Static;
        
    }
    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
