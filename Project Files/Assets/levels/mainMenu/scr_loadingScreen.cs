using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scr_loadingScreen : MonoBehaviour {

    public Slider sldr; // Reference to the slider being used
    public float sldrProgress = 0;
    public bool loadingProgress = false;

	public void startLoad () {
        sldr.enabled = true; // Makes slider visible
        loadingProgress = true; // Enables the timer/scene loading
	}
    
    private void Update()
    {
        // Just used to update the loading bar
        sldr.value = sldrProgress;

        // Timer used to fake the loading process, so we can experience a loading screen
        if (loadingProgress)
        {
            sldrProgress = sldrProgress + (Time.deltaTime / 10);
            if (sldrProgress > 1)
            {
                // Calls an operation that actually loads the level
                AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("ingame");
            }

        }
    }
}
