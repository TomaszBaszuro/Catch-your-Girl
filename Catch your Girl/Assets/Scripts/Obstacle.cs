using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float rotationSpeed;

    private void FixedUpdate()
    {
        transform.Rotate(0, 0, rotationSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            GameManager.Instance.GameOver();
        }

        if (collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
            GameManager.Instance.IncrementScore();

        }
    }
}
