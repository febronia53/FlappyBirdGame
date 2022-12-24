using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContrroler : MonoBehaviour
{
    private Rigidbody2D rb;

    private float move=0.1f;

    public float speed;

    public float jump;

    private bool isjumping;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

  
    // Update is called once per frame
    void Update()
    {

       
        move = Input.GetAxisRaw("Horizontal"); 
        rb.velocity=new Vector2(speed, rb.velocity.y);

        if ( move < 0|| Input.GetKey("left"))
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            transform.Translate(new Vector3(-speed, 0f, 0f));
            animator.SetBool("move", true);

        }

        else if (move >0|| Input.GetKey("right"))
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            transform.Translate(new Vector3(speed, 0f, 0f));
            animator.SetBool("move", true);

        }
        else if (move ==0)
        {
            animator.SetBool("move", false);

        }

        if(Input.GetButtonDown("Jump")&& !isjumping)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            isjumping=true;
            animator.SetBool("isjumping", true);
        }

        if(!isjumping)
        {
            animator.SetBool("isjumping", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isjumping = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
            Destroy(other.gameObject);
        }
    }
}
