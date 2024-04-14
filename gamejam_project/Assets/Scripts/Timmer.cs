using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timmer : MonoBehaviour
{
    public static int count = 0;
    public string scene;
    public float Timer;
    public Text TimerText;

    private void Update()
    {
        Timer -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(Timer / 60F);
        int seconds = Mathf.FloorToInt(Timer % 60F);
        int milliseconds = Mathf.FloorToInt((Timer * 100F) % 100F);
        TimerText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
    }
}
