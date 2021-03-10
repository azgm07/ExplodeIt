using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Explodable : MonoBehaviour
{
    public GameObject explosion;
    public Vector3 explosionOffset;
    //public GameObject smoke;
    //public int maxSmokes = 3;
    public float destroyDelay = 5;
    public float minForce = 100;
	public float maxForce = 300;
	public float radius = 10;

    public void Explode(){
        //int smokeCounter = 0;

        if(explosion != null)
        {
            GameObject explosionFX = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy (explosionFX, 3);
        }
		foreach(Transform t in transform)
		{
			var rb = t.GetComponent<Rigidbody>();
			if(rb != null)
			{
				rb.AddExplosionForce(UnityEngine.Random.Range(minForce,maxForce), transform.position, radius);
			}

            // if(smoke != null && smokeCounter < maxSmokes)
            // {
            //     if(UnityEngine.Random.Range(1, 4) == 1)
            //     {
            //         GameObject smokeFX = Instantiate(smoke, t.transform);
            //         Destroy(smokeFX, destroyDelay);
            //         smokeCounter++;
            //     }
            // }

		}
        StartCoroutine(Destroy());
	}

    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(destroyDelay);
        //GameController.Instance?.Destroy(this.gameObject);
        Destroy(this.gameObject);
    }
}
