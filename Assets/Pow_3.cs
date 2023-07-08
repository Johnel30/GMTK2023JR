using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pow_3 : MonoBehaviour
{
    public GameObject pictureObject;
    public float newTime;
    public float delayTime;
    
    public Timer_Fight_Screen timerFightScreen;

    public IEnumerator DisplayPictureCoroutine()
    {
        
            pictureObject.SetActive(true); // Show the picture

            yield return new WaitForSeconds(delayTime);

            pictureObject.SetActive(false); // Hide the picture
            timerFightScreen.currentTime = newTime;
        
    }
}
