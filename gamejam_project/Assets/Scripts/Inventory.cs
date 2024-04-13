using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;
    public GameObject panel;
    public bool isOpen;

    private void Update()
    {
        
        if(!isOpen)
        {
            if (Input.GetKeyDown((KeyCode.X)))
            {
                panel.SetActive(true);
                isOpen = true;
                Time.timeScale = 0f;
            }
        }

        else
        {
            if (Input.GetKeyDown((KeyCode.X)))
            {
                panel.SetActive(false);
                isOpen = false;
                Time.timeScale = 1f;
            }
        }
            
        
    }
}
