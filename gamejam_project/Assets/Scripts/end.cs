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
            int choiceSum = StaticData.choice1 + StaticData.choice2 + StaticData.choice3 + StaticData.finalchoice;
            if (choiceSum >= 2)
            {
                SceneManager.LoadScene("Good"); // good ending
            }
            else if (2 > choiceSum && choiceSum >= 0)
            {
                SceneManager.LoadScene("Badd"); // bad ending
            }
            Debug.Log(StaticData.choice3.ToString());
            
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
