using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque : MonoBehaviour {

    private bool pisado = false;
    public int puntosGanados = 0;
	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!pisado && collision.gameObject.tag == "Player")
        {
            GameObject obj = collision.contacts[0].collider.gameObject;
            if (obj.name == "PieDerecho" || obj.name == "PieIzquierdo")
            {
                pisado = true;
                NotificationCenter.DefaultCenter().PostNotification(this, "incrementarPuntos", puntosGanados);
            }
        }
    }


    // Update is called once per frame
    void Update () {
		
	}
}
