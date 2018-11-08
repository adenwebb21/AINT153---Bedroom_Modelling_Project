using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractingWithDoor : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Door")
        {

        }
    }
}
