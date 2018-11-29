using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirPersonaje : MonoBehaviour {

    public Transform personaje;
    public float separacion = 6f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(personaje.position.x+separacion, transform.position.y, transform.position.z);

    }
}
