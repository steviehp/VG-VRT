using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartExercise : MonoBehaviour
{
    //Instantiates 3 objects
    public GameObject exercise;
    public GameObject startTrigger;
    public GameObject stopTrigger;

    //On collision with a GameObject with the tage GameController
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GameController")
        {
            //Set the exercise active, make the start button disappear and the stop button appear
            exercise.SetActive(true);
            startTrigger.SetActive(false);
            stopTrigger.SetActive(true);
        }
    }
}
