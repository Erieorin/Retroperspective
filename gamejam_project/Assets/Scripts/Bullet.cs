using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public float thrust;
    public Rigidbody2D rb;
    private float TimeToLive = 1;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.AddForce(transform.right * thrust, ForceMode2D.Impulse);

        if(TimeToLive > 0)
        {
            TimeToLive -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Timmer.count++;
        }
    }
}