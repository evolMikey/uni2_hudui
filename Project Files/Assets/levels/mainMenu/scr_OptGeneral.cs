using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class scr_OptGeneral : MonoBehaviour {

    // Display Character Names
    private string tt_dispNamePlayer = "Toggles the display of character names for players, NPCs and monsters respectively";
    // Auto Pause During Combat
    private string tt_autoPauseGame = "Pauses gameplay when new enemies are encountered";
    // Faction-Coloured Icons
    private string tt_factionIcons = "NPCs will be coloured based on what faction they belong to";
    // Display Combat Damage
    private string tt_displayCombatDamage = "Damage values will appear when a character is harmed";
    // Game Difficult
    private int gameDifficulty = 2;
    public Text txt_gameDifficulty;
    private string tt_gameDifficulty = "Modifies health and damage of NPCs and Monsters";
    // Tooptips for the blank settings
    private string tt_fakeSettings = "Extra settings that would do something in a real game";
    private string tt_fakeSlider = "Extra setting on a slider, could affect range?";
    private string tt_fakeChecks = "Extra setting using checks, any variation of these can be chosen";

    // Fake Radios, requires a little more effort
    private string tt_fakeRadio = "Extra setting using radios, only one can be checked";
    private int fakeRadio = 0;
    public GameObject rada;
    public GameObject radb;
    public GameObject radc;
    public GameObject radd;

    public Canvas ctt_dispChar;
    public Canvas ctt_autoPause;
    public Canvas ctt_factionColour;
    public Canvas ctt_numericStatus;
    public Canvas ctt_dispCombat;
    public Canvas ctt_gameDifficulty;
    public Canvas ctt_fakeOpt;
    public Canvas ctt_fakeSlider;
    public Canvas ctt_fakeTgl;
    public Canvas ctt_fakeRad;
    public GameObject ctt_InfoBox;

    private string tt_fixUI = "Its not a bug, its a feature";

    // Changes difficulty of the game
    public void changeDifficulty(bool increase)
    {
        // Increases/decreases difficulty based on input
        if ((gameDifficulty != 0) && (!increase))
            gameDifficulty--;
        if ((gameDifficulty != 4) && (increase))
            gameDifficulty++;

        // Sets new word
        if (gameDifficulty == 0)
            txt_gameDifficulty.text = "EASIEST";
        if (gameDifficulty == 1)
            txt_gameDifficulty.text = "EASY";
        if (gameDifficulty == 2)
            txt_gameDifficulty.text = "NORMAL";
        if (gameDifficulty == 3)
            txt_gameDifficulty.text = "HARD";
        if (gameDifficulty == 4)
            txt_gameDifficulty.text = "IMPOSSIBLE";
    }

    public void changeFakeRadio(int input)
    {
        fakeRadio = input;
    }

    public void createTooltip(string infoNeeded)
    {
        switch (infoNeeded)
        {
            case "dispChar":
                ctt_InfoBox.transform.Find("Text").GetComponent<Text>().text = tt_dispNamePlayer;
                ctt_InfoBox.SetActive(true);
                break;
            case "autoPause":
                ctt_InfoBox.transform.Find("Text").GetComponent<Text>().text = tt_autoPauseGame;
                ctt_InfoBox.SetActive(true);
                break;
            case "factionColour":
                ctt_InfoBox.transform.Find("Text").GetComponent<Text>().text = tt_factionIcons;
                ctt_InfoBox.SetActive(true);
                break;
            case "numericStatus":
                ctt_InfoBox.transform.Find("Text").GetComponent<Text>().text = tt_displayCombatDamage;
                ctt_InfoBox.SetActive(true);
                break;
            case "dispCombat":
                ctt_InfoBox.transform.Find("Text").GetComponent<Text>().text = tt_displayCombatDamage;
                ctt_InfoBox.SetActive(true);
                break;
            case "gameDifficulty":
                ctt_InfoBox.transform.Find("Text").GetComponent<Text>().text = tt_gameDifficulty;
                ctt_InfoBox.SetActive(true);
                break;
            case "fakeOpt":
                ctt_InfoBox.transform.Find("Text").GetComponent<Text>().text = tt_fakeSettings;
                ctt_InfoBox.SetActive(true);
                break;
            case "fakeSlider":
                ctt_InfoBox.transform.Find("Text").GetComponent<Text>().text = tt_fakeSlider;
                ctt_InfoBox.SetActive(true);
                break;
            case "fakeTgl":
                ctt_InfoBox.transform.Find("Text").GetComponent<Text>().text = tt_fakeChecks;
                ctt_InfoBox.SetActive(true);
                break;
            case "fakeRad":
                ctt_InfoBox.transform.Find("Text").GetComponent<Text>().text = tt_fakeRadio;
                ctt_InfoBox.SetActive(true);
                break;
            case "fixUI":
                ctt_InfoBox.transform.Find("Text").GetComponent<Text>().text = tt_fixUI;
                ctt_InfoBox.SetActive(true);
                break;
            case "exited":
                ctt_InfoBox.SetActive(false);
                break;
            default:
                ctt_InfoBox.SetActive(false);
                break;
        }
    }


}
