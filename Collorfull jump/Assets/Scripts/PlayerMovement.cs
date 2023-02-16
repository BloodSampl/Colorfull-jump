using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    Rigidbody2D rb;
    Vector2 velocity;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Move();
        Jump();
    }
    void Move()
    {
        velocity = new Vector2(Input.GetAxis("Horizontal"), rb.velocity.y);
        rb.velocity = velocity * speed;
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
