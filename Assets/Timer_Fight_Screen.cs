using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer_Fight_Screen : MonoBehaviour
{

    public Pow_2 Pow_2;
    public Pow_3 Pow_3;
    public float totalTime; // Total time in seconds
    public float currentTime;


    private void Start()
    {
        currentTime = totalTime;
        
    }

    private void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;

            // You can perform actions or update UI based on the current time here
            Debug.Log("Time: " + currentTime.ToString("F2")); // Example: Display time in console

            if (currentTime <= 0)
            {
                // Timer has reached zero, perform any necessary actions
                Debug.Log("Time's up!");
                //Here is where the magic happens
                StartCoroutine(Pow_2.DisplayPictureCoroutine());
                
            }
        }
    }
}
