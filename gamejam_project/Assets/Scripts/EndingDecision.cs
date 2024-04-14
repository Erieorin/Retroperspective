using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingDecision : MonoBehaviour
{
    public static int endingNumber;

    public void endingDesicion()
    {
        int choiceSum = StaticData.choice1 + StaticData.choice2 + StaticData.choice3 + StaticData.finalchoice;
        if (choiceSum >= 2)
        {
            endingNumber = 1; // good ending
        }
        else if (2 > choiceSum && choiceSum >= 0)
        {
            endingNumber = 2; // bad ending
        }
        else
        {
            endingNumber = 0; // worst ending
        }
    }
}
