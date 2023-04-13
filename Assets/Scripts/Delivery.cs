using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    // Built in unity function to detect a collision between objects
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // check if we are passing over a package
        if (collision.CompareTag("Package"))
        {
            Debug.Log("We found the package");
        }
    }
}
