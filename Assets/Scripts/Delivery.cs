using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Package"))
        {
            Debug.Log("Package picked up");
        } 
        else if(other.CompareTag("Customer"))
        {
            Debug.Log("Delivered package");
        }
    }
}
