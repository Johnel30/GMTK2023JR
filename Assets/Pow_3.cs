using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pow_3 : MonoBehaviour
{
    public GameObject pictureObject;
    public float newTime;
    public float delayTime;

    public bool canClick;
    public Timer_Fight_Screen timerFightScreen;
    public Button_Press button_pressed;

    public IEnumerator DisplayPictureCoroutine()
    {
        pictureObject.SetActive(true); // Show the picture
        canClick = true;
        while (delayTime > 0)
        {
            delayTime -= Time.deltaTime;

            if (button_pressed.canContinue)
            {
                delayTime = 0f;
            }

            yield return null; // Yield control back to Unity
        }

        pictureObject.SetActive(false); // Hide the picture
        canClick = false;
        timerFightScreen.currentTime = newTime;
    }
}
