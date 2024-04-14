using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activities : MonoBehaviour
{
    public GameObject daddy;
    public GameObject Sasha;
    public GameObject Buttons;
    public GameObject t1;
    public GameObject t2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SashaApp()
    {
        Sasha.SetActive(false);
    }

    public void DadApp()
    {
        daddy.SetActive(true);
    }

    public void ButtonsUp()
    {
        Buttons.SetActive(true);
        t1.SetActive(true);
        t2.SetActive(true);
    }
}
