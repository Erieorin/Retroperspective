using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangingScenes : MonoBehaviour
{
    public string scene;
    private bool allowed;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M) && allowed)
        {
            SceneManager.LoadSceneAsync(scene);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            allowed = true;
        }

    }

}