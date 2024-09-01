using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;

    [SerializeField] Color32 hasPackageColor = new Color32(255, 255, 255, 255);

    [SerializeField] Color32 noPackageColor = new Color32(255, 255, 255, 255);

    [SerializeField] float timer = 1f;

    SpriteRenderer spriteRenderer;

    private void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();    
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            Destroy(other.gameObject, timer);
            spriteRenderer.color = hasPackageColor;
        } 
        else if(other.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Delivered package");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
