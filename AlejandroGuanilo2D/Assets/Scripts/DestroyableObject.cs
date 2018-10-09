using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableObject : MonoBehaviour {

    void Awake () {
        GameControl.instance.objectiveInstances.Add (this);
    }
	
	// Update is called once per frame
	public void DestroySelf () {
        GameControl.instance.CheckInstancePoint (this);
        Destroy (gameObject);
	}
}
