using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl : MonoBehaviour
{
    private SpriteRenderer girl;

    private void Awake()
    {
        girl = GetComponent<SpriteRenderer>();

    }

    private void Start()
    {
        StartCoroutine(FlipGirl());
    }
   
    IEnumerator FlipGirl()
    {
        while (true) 
        { 
        girl.flipX = !girl.flipX;
        yield return new WaitForSeconds(0.2f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            GameManager.Instance.IncrementScore();
        }

        if (collision.gameObject.tag == "Ground")
        {
            Time.timeScale = 0.0f;
            GameManager.Instance.GameOver();

        }
    }
}
