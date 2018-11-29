using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuacion : MonoBehaviour {

    private int puntuacion = 0;
    public TextMesh marcador;

    // Use this for initialization
    void incrementarPuntos(Notification notificacion)
    {
        int puntosAIncrementar = (int)notificacion.data;
        puntuacion += puntosAIncrementar;
        actualizarMarcador();
    }
    void actualizarMarcador()
    {
        marcador.text = puntuacion.ToString();
    }

    void Start () {
        NotificationCenter.DefaultCenter().AddObserver(this, "incrementarPuntos");
        //NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");
        actualizarMarcador();

    }
    
    // Update is called once per frame
    void Update () {
		
	}
}
