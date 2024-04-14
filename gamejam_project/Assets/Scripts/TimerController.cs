using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerController : MonoBehaviour
{
    public Image timer;
    float timer_remaining;
    public float max_time = 5.0f;
    public GameObject v1;


    void Start()
    {
        timer_remaining = max_time;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer_remaining > 0)
        {
            timer_remaining -= Time.deltaTime;
            timer.fillAmount = timer_remaining / max_time;
        }
        else
        {
            SceneManager.LoadScene("DimaBadFa");
            v1.SetActive(false);
            //выбор пойдет в другую сторону, типо что не успел дима отреагировать
            //если нажать кнопку успеть, то все ок и пойдет по нужной ветке или сменится сцена
        }

    }
}