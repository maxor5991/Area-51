using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    public int puntuacion = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Player")
        {

       NotificationCenter.DefaultCenter().PostNotification(this, "incrementarPuntos", puntuacion);
			 Destroy(gameObject);

        }
    }
}
