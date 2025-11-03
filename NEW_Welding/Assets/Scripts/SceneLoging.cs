using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoging : MonoBehaviour
{
    // Call this function from the UI button
    public void LoadHotRefiningScene()
    {
        SceneManager.LoadScene("CMR_Hot_Refining_VR");
    }

    public void HindiScene()
    {
        SceneManager.LoadScene("");
    }

    public void Main_Menu()
    {
        SceneManager.LoadScene("CMR_Hot_Refining_VR_Language_Selection");
    }

    public void Application_Quit()
    {
        Application.Quit();
    }
}