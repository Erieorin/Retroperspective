using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float moveSpeed;
    public Rigidbody2D rb;
    public bool grounded;

    void Update()
    {
        float hor = Input.GetAxisRaw("Horizontal"); //получение направления
        rb.velocity = new Vector2(hor * moveSpeed, rb.velocity.y); //движение

        // поворачивание игрока 
        if (hor > 0.01f)
        {
            transform.localScale = Vector3.one;
        }
        if (hor < -0.01f)
        {  transform.localScale = new Vector3(-1, 1, 1);}
        
        // прыжок
        if(Input.GetKey(KeyCode.Space) && grounded)
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, moveSpeed);
        grounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }

}
