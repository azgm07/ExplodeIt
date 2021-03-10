using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour
{
    public GameObject originalVersion;
    public GameObject destroyedVersion;

    private void Start() {
        GameController.Instance.OnExplodeObject += ExplodeObject;
        //GameController.Instance.OnDestroyObject += Respawn;
    }

    private void ExplodeObject(GameObject original)
	{
        if(original.transform.parent == this.transform)
        {
            // Remove the current object
            Destroy(original);
            // Spawn a shattered object
            GameObject destructable = Instantiate(destroyedVersion,this.transform);
            destructable.GetComponent<Explodable>().Explode();
        }
    }

    // private void Respawn(GameObject obj)
    // {
    //     if(obj.transform.parent == this.transform)
    //     {
    //         Instantiate(originalVersion,this.transform);
    //     }
    // }
}
