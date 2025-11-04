using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void Homepage()
    {
        SceneManager.LoadScene("MainMenu_Scene");
    }

    public void TIGEnglish()
    {
        SceneManager.LoadScene("TIG_WELDING_SCENE_English");
    }

    public void TIGHinid()
    {
        SceneManager.LoadScene("TIG_WELDING_SCENE_Hindi");

    }

    public void MIGEnglish()
    {
        SceneManager.LoadScene("MIG_WELDING_SCENE_English");
    }

    public void MIGHindi()
    {
        SceneManager.LoadScene("MIG_WELDING_SCENE_Hindi");
    }

    public void SPOTEnglish()
    {
        SceneManager.LoadScene("SPOT_WELDING_SCENE_English");
    }

    public void SPOTHindi()
    {
        SceneManager.LoadScene("SPOT_WELDING_SCENE_Hindi");
    }
}
