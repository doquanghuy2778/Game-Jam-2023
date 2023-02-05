using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjDestroy : MonoBehaviour
{
    private BoxCollider boxCollider;
    private MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();  
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Rocket")
        {
            CollisionCtl collisionCtl = other.transform.GetComponent<CollisionCtl>();
            if (collisionCtl.isScaleUp)
            {
                // add destroy sound effect here
                Destroy(gameObject);
            }
        }
    }
}
