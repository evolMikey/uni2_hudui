using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scr_TextScroll : MonoBehaviour {

    public RectTransform creditText; // Object containing credit text
    public float creditPosition = -1400f; // Rectposition just below the screen
    public float credLerp = 0; // Don't mess with, used for lerp function
    public float credLength = 186f; // Amount of time to run credits for

	// Use this for initialization
	void Start () {
        StartCoroutine(waitForCreditEnd()); // Calls a coroutine that will return to main menu at end of credits
	}
	
	// Update is called once per frame
	void Update () {
        credLerp = credLerp + (Time.deltaTime / credLength); // Used in lerp function, increments value over time
        creditPosition = Mathf.Lerp(-850f, 850f, credLerp); // Changes position from very bottom of screen to very top
        creditText.anchoredPosition = new Vector2(0, creditPosition); // Applies change of position to the credit text

        // Escape button typically cuts the credits short and goes back to main menu
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("mainMenuLevel");
        }
	}

    private IEnumerator waitForCreditEnd() {
        yield return new WaitForSeconds(credLength + 5); // Waits for set amount of time
        SceneManager.LoadScene("mainMenuLevel"); // Returns to main menu
    }
}
