using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    public void OnClickGood()
    {

        SceneManager.LoadScene("DimaGoodFa");
    }

    public void OnClickBad()
    {
        SceneManager.LoadScene("DimaBadFa");
    }
}
