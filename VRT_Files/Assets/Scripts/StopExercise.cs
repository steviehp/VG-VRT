using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopExercise : MonoBehaviour
{
    //Instantiates 3 objects
    public GameObject exercise;
    public GameObject startTrigger;
    public GameObject stopTrigger;

    //On collision with object with tag "GameController"
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GameController")
        {
            //Set exercise inactive, set start button active, set stop button inactive
            exercise.SetActive(false);
            startTrigger.SetActive(true);
            stopTrigger.SetActive(false);
        }
    }
}
