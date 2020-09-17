using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class src_menuSwaps : MonoBehaviour {

    // Reference to each screen's canvas
    public GameObject MainScreen;
    public GameObject TitleScreen;
    public GameObject LoadScreen;
    public GameObject OptGeneralScreen;
    public GameObject TransitionScreen;
    public GameObject QuitPrompt;
    public scr_loadingScreen loadingScript;

    public Image splash1;
    public Image splash2;

    // Use this for initialization
    void Start ()
    {
        // Ensures that all menus are invisible on begin play
        TitleScreen.SetActive(false);
        MainScreen.SetActive(false);
        LoadScreen.SetActive(false);
        OptGeneralScreen.SetActive(false);
        TransitionScreen.SetActive(false);
        QuitPrompt.SetActive(false);
        StartCoroutine(splashScreenStart());
    }

    private IEnumerator splashScreenStart()
    {
        splash1.gameObject.SetActive(true);
        splash2.gameObject.SetActive(false);
        yield return new WaitForSeconds(7);
        splash2.gameObject.SetActive(true);
        splash1.gameObject.SetActive(false);
        yield return new WaitForSeconds(7);
        splash2.gameObject.SetActive(false);
        setScreenTo("TitleScrn");
    }

    public void setScreenTo(string newScreen)
    {
        // Sets every screen to disabled
        TitleScreen.SetActive(false);
        MainScreen.SetActive(false);
        LoadScreen.SetActive(false);
        OptGeneralScreen.SetActive(false);
        TransitionScreen.SetActive(false);
        QuitPrompt.SetActive(false);

        // Switch case will enable the correct screen
        // Defaults back to main menu if everything else breaks
        switch (newScreen)
        {
            case "TitleScrn":
                TitleScreen.SetActive(true);
                break;
            case "MainScrn":
                MainScreen.SetActive(true);
                break;
            case "LoadScrn":
                LoadScreen.SetActive(true);
                break;
            case "OptGeneralScrn":
                OptGeneralScreen.SetActive(true);
                break;
            case "TransitionScrn":
                TransitionScreen.SetActive(true);
                loadingScript.startLoad();
                break;
            case "QuitScrn":
                MainScreen.SetActive(true);
                QuitPrompt.SetActive(true);
                break;
            case "CreditsScrn":
                SceneManager.LoadScene("creditsLevel");
                break;
            case "ExitGame":
                Application.Quit();
                break;
            default:
                MainScreen.SetActive(true);
                break;
        }
    }
}
