﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionController : MonoBehaviour
{
    //This script basically makes the camera follow a gameobject, used for third person games
    //Remember to drag the camera to this field in the inspector
    public Transform cameraTransform;
    //Set it to whatever value you think is best
    public float distanceFromCamera;
    void Update()
    {
        Vector3 resultingPosition = cameraTransform.position + cameraTransform.forward * distanceFromCamera;
        transform.position = new Vector3(resultingPosition.x, transform.position.y, resultingPosition.z);
    }
}