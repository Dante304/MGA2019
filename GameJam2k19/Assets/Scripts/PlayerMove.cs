using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float speed;
    public bool stop;
    public float moveInput;
    public float jumpForce;
    private bool isGrounded;


    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;

    private float jumpTimeCounter;
    public float jumpTime;
    private bool isJumping;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();    
    }

    void FixedUpdate()
    {
        if (!stop)
        {
            moveInput = Input.GetAxisRaw("Horizontal");
            if (moveInput > 0)
            {
                rb2d.GetComponentInChildren<SpriteRenderer>().flipX = false;
            }
            else if (moveInput < 0)
            {
                rb2d.GetComponentInChildren<SpriteRenderer>().flipX = true;
            }
            rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y);
        }
    }

    void Update()
    {
        if (!stop)
        {
            Move();
        }
    }

    private void Move()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb2d.velocity = Vector2.up * jumpForce;
        }
        if (Input.GetKey(KeyCode.Space) && isJumping == true)
        {
            if (jumpTimeCounter > 0)
            {
                rb2d.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }

    }

}
