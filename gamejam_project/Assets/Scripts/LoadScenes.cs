using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    public void OnClickGood()
    {
        SceneManager.LoadScene("DimaGoodFa");
        StaticData.choice3 = 1;
        //KeepChoiceValueAndLoadNextScene(1);
    }

    public void OnClickBad()
    {
        SceneManager.LoadScene("DimaBadFa");
        StaticData.choice3 = 0;
        //KeepChoiceValueAndLoadNextScene(0);
    }

    public void OnClickGood_choice2()
    {
        SceneManager.LoadScene("GoodChoiceUni");
        StaticData.choice2 = 1;
    }

    public void OnClickBad_choice2()
    {
        SceneManager.LoadScene("BadChoiceUni");
        StaticData.choice2 = 0;
    }

    public void OnClickGood_choice1()
    {
        SceneManager.LoadScene("UniversityTalk");
        StaticData.choice1 = 1;
    }

    public void OnClickBad_choice1()
    {
        SceneManager.LoadScene("UniversityTalk");
        StaticData.choice1 = 0;
    }
}
