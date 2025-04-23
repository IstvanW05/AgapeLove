using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ImageFade1 : MonoBehaviour {

    // the image you want to fade, assign in inspector
    public Image img;
    public bool fadeAway;
    public GameObject DialogueBox;
    public GlobalManager globalManager;
    
    void Start()
    {
        StartCoroutine(FadeImage(fadeAway));
    }

    IEnumerator FadeImage(bool fadeAway)
    {
        // fade from opaque to transparent
        if (fadeAway)
        {
            // loop over 1 second backwards
            for (float i = 1; i >= 0; i -= Time.deltaTime)
            {
                // set color with i as alpha
                img.color = new Color(1, 1, 1, i);
                yield return null;
            }

            DialogueBox.SetActive(true);
        }
        // fade from transparent to opaque
        else
        {
            // loop over 1 second
            for (float i = 0; i <= 1; i += Time.deltaTime)
            {
                // set color with i as alpha
                img.color = new Color(1, 1, 1, i);
                yield return null;
            }

            if(globalManager.gotHeart)
            {
                globalManager.addHeart();
                globalManager.resetGotHeart();
            }
            SceneManager.LoadScene("Apartment Day 20 (new)");
            
        }
    }
}
