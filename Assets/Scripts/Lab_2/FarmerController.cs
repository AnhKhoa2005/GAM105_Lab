using System;
using UnityEngine;

public class FarmerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] SpriteRenderer basketSprite;
    [SerializeField] BoxCollider2D basketCollider;

    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private float xDir = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Flip();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(xDir * moveSpeed, rb.linearVelocity.y);
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            xDir = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            xDir = 1;
        }
        else
        {
            xDir = 0;
        }
    }

    void Flip()
    {
        if (xDir > 0)
        {
            sr.flipX = false;
            basketSprite.flipX = false;
            basketCollider.offset = new Vector2(0.5f, -0.6f);
        }
        else if (xDir < 0)
        {
            sr.flipX = true;
            basketSprite.flipX = true;
            basketCollider.offset = new Vector2(-0.5f, -0.6f);
        }
    }
}
