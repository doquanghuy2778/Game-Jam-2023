using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleDown : MonoBehaviour
{
    private BoxCollider boxCollider;
    private void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Rocket")
        {
            gameObject.transform.localScale *= 0;
            boxCollider.enabled = false;
            CowndownTime.ins.ActiveCoutdownEvent();
        }
    }
}
