using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer_Fight_Screen : MonoBehaviour
{

    public Pow_2 Pow_2;
    public Pow_3 Pow_3;
    public float totalTime; // Total time in seconds
    public float currentTime;
    public float count;

    

    private void Start()
    {
        currentTime = totalTime;
    }

    private void Update()
    {
        //Pow_2 actives first
        if (currentTime > 0 && count == 0)
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
                count+= 1; //So that Pow_3 can activate after this one
            }
        }

        else if (currentTime > 0 && count == 1)
            {
                currentTime -= Time.deltaTime;

                // You can perform actions or update UI based on the current time here
                Debug.Log("Time: " + currentTime.ToString("F2")); // Example: Display time in console

                if (currentTime <= 0)
                {
                    // Timer has reached zero, perform any necessary actions
                    Debug.Log("Time's up!");
                    //Here is where the magic happens
                    StartCoroutine(Pow_3.DisplayPictureCoroutine());
                    count+= 1; //So that Pow_3 can activate after this one
                }
            }
        else {
            Debug.Log("Finished");
        }
    }
}
