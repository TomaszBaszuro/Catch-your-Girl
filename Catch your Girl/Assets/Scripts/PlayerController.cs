using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer rbSprite;
    BoxCollider2D rbBoxCollider;
    public float moveSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rbSprite = rb.GetComponent<SpriteRenderer>();
        rbBoxCollider = rb.GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {
        if(Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x < Screen.width / 2)
            {
                //move left
                rb.velocity = Vector2.left * moveSpeed;
                rbSprite.flipX = true;
                rbBoxCollider.offset = new Vector2(0.947082f, -0.06396651f);

            }
            else
            {
                //move right
                rb.velocity = Vector2.right * moveSpeed;
                rbSprite.flipX = false;
                rbBoxCollider.offset = new Vector2(-0.947082f, -0.06396651f);
            }
        }
    }
}
