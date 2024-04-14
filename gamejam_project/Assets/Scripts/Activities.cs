using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Activities : MonoBehaviour
{
    public GameObject daddy;
    public GameObject mommy;
    public GameObject Sasha;
    public GameObject Dima;
    public GameObject Buttons;
    public GameObject t1;
    public GameObject t2;
    public Image imageComp;
    public Sprite newImage;

    public GameObject buttonChoice2;
    public GameObject buttonChoice2_2;

    public void SashaApp()
    {
        Sasha.SetActive(true);
    }

    public void SashaDis()
    {
        Sasha.SetActive(false);
    }

    public void DimaApp()
    {
        Dima.SetActive(true);
    }

    public void DimaDis()
    {
        Dima.SetActive(false);
    }

    public void MomApp()
    {
        mommy.SetActive(true);
    }

    public void MomDis()
    {
        mommy.SetActive(false);
    }

    public void DadApp()
    {
        daddy.SetActive(true);
    }

    public void DadDis()
    {
        daddy.SetActive(false);
    }

    public void ButtonsUp()
    {
        Buttons.SetActive(true);
        t1.SetActive(true);
        t2.SetActive(true);
    }

    public void ButtonChoice2()
    {
        buttonChoice2.SetActive(true);
        buttonChoice2_2.SetActive(true);
    }

    public void ChangeImage()
    {
        imageComp.sprite = newImage;
    }


}
