using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    #region VARIABLES
    public GameObject screenExitValidation;

    public GameObject sreenAboutMe;
    #endregion

    #region METHODS
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void ShowValidationScreen(bool active)
    {
        screenExitValidation.SetActive(active);
    }

    public void ShowScreenAboutMe(bool active)
    {
        sreenAboutMe.SetActive(active);
    }
    #endregion
}
