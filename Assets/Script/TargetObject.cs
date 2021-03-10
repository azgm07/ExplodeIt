using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TargetObject : MonoBehaviour
{
    public float velocityToExplode = 2;
    // void OnMouseDown() {
    //     OnExplodeObject?.Invoke(this.gameObject);
    // }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Arrow"){
            GameController.Instance?.Explode(this.gameObject);
            Destroy(other.gameObject);
        }

    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Wreckage")
        {
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            if(rb != null)
            {
                if(rb.velocity.magnitude > velocityToExplode)
                {
                    GameController.Instance?.Explode(this.gameObject);
                }
            }
            Destroy(other.gameObject);
        }
    }
}
