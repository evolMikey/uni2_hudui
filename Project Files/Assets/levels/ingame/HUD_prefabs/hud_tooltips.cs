using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class hud_tooltips : MonoBehaviour {

    private string tt_fortify = "The warrior takes up a defensive stance, +15 to constitution but prohibits attacks";
    private string tt_eyespy = "The rogue uses their keen eyesight, +5 to awareness and +10 to stealth";
    private string tt_haste = "The hero sprints through the world, +7 to speed";
    private string tt_cards = "The rogue slips an ace down their sleeve, +10 to gambling";
    private string tt_bribe = "The hero hands the target a small pouch of gold, gaining their favour for a time";
    private string tt_poision = "The rogue pours a few drops into the victim's cup, they die within minutes";
    private string tt_potion = "The hero recovers health more rapidly, +10 recovery rate";
    private string tt_healthBar = "This is the heroes health. When it depletes, they die";
    private string tt_manaBar = "This is the heroes mana. When it depletes, they are unable to cast magic";
    public GameObject ctt_InfoBox;

    public IEnumerator startCredits()
    {
        yield return new WaitForSeconds(30);
        SceneManager.LoadScene("creditsLevel");
    }

	public void createToolTip(string infoNeeded)
    {
        switch (infoNeeded)
        {
            case "fortify":
                ctt_InfoBox.transform.Find("Text").GetComponent<Text>().text = tt_fortify;
                ctt_InfoBox.SetActive(true);
                break;
            case "eyespy":
                ctt_InfoBox.transform.Find("Text").GetComponent<Text>().text = tt_eyespy;
                ctt_InfoBox.SetActive(true);
                break;
            case "haste":
                ctt_InfoBox.transform.Find("Text").GetComponent<Text>().text = tt_haste;
                ctt_InfoBox.SetActive(true);
                break;
            case "cards":
                ctt_InfoBox.transform.Find("Text").GetComponent<Text>().text = tt_cards;
                ctt_InfoBox.SetActive(true);
                break;
            case "bribe":
                ctt_InfoBox.transform.Find("Text").GetComponent<Text>().text = tt_bribe;
                ctt_InfoBox.SetActive(true);
                break;
            case "poison":
                ctt_InfoBox.transform.Find("Text").GetComponent<Text>().text = tt_poision;
                ctt_InfoBox.SetActive(true);
                break;
            case "potion":
                ctt_InfoBox.transform.Find("Text").GetComponent<Text>().text = tt_potion;
                ctt_InfoBox.SetActive(true);
                break;
            case "healthBar":
                ctt_InfoBox.transform.Find("Text").GetComponent<Text>().text = tt_healthBar;
                ctt_InfoBox.SetActive(true);
                break;
            case "manaBar":
                ctt_InfoBox.transform.Find("Text").GetComponent<Text>().text = tt_manaBar;
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
