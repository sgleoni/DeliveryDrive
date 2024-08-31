using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Simple script to make the camera follow the car
public class FollowCamera : MonoBehaviour
{
    // Reference to the car object
    [SerializeField] GameObject car;

    void LateUpdate()
    {
        transform.position = car.transform.position + new Vector3(0, 0, -10);
    }
}
