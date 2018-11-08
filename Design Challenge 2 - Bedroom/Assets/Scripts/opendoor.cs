using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Animation>().Play("dooropen");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
