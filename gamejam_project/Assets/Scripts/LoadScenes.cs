using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    public void OnClickGood()
    {

        SceneManager.LoadScene("DimaGoodFa");
        //KeepChoiceValueAndLoadNextScene(1);
    }

    public void OnClickBad()
    {
        SceneManager.LoadScene("DimaBadFa");
        //KeepChoiceValueAndLoadNextScene(0);
    }
}
