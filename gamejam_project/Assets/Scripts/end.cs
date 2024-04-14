using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    public bool playerinrange;


    private void Update()
    {
        if(playerinrange)
        {
            Debug.Log(EndingDecision.endingNumber.ToString());
            if (EndingDecision.endingNumber == 1)
            {
                SceneManager.LoadScene("Good");
            }
            if (EndingDecision.endingNumber == 2)
            {
                SceneManager.LoadScene("Badd");
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerinrange = true;
        }

    }
}
