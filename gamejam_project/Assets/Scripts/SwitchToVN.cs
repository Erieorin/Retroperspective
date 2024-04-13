using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SwitchToVN : MonoBehaviour
{
    public GameObject dialogBox;
    public TMP_Text dialogText;
    public string dialog;
    public bool PlayerInRange;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("triggervn"))
        {
            PlayerInRange = true;
            dialogBox.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("triggervn"))
        {
            PlayerInRange = false;
            dialogBox.SetActive(false);
        }
    }
}
