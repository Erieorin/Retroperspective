using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    public GameObject Object;
    public bool active;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) && active)
        {
            Object.SetActive(true);
            active = false;
        }
        if(Input.GetKeyDown(KeyCode.V) && !active)
        {
            Object.SetActive(false);
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            active = true;
        }
    }
}
