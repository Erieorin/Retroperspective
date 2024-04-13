using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject Bullet;
    public float time;
    private float timeRemaining;

    private void Start()
    {
        timeRemaining = time;
    }
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }

        else
        {
            Instantiate(Bullet, Bullet.transform.position, Bullet.transform.rotation);
            timeRemaining = time;
            
        }
    }
}
