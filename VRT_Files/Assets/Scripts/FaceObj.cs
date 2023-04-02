using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceObj : MonoBehaviour
{
    //This script has the camera constantly facing the player
    public Transform Camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(transform.position + Camera.transform.rotation * Vector3.forward,
            Camera.transform.rotation * Vector3.up);
    }
}
