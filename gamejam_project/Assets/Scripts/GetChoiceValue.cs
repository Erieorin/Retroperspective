using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetChoiceValue : MonoBehaviour
{
    [SerializeField] int choiceNumber;
    [SerializeField] string nextScene;

    public void KeepChoiceValue(int choiceDigit)
    {
        switch (choiceNumber)
        {
            case 1:
                StaticData.choice1 = choiceDigit;
                break;
            case 2:
                StaticData.choice2 = choiceDigit;
                break;
            case 3:
                StaticData.choice3 = choiceDigit;
                break;
            case 4:
                StaticData.finalchoice = choiceDigit;
                break;
        }
    }
}
