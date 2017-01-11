using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarcadorRosa : MonoBehaviour {
	public Text texto_marcador;
	int goles = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.transform.name == "Pelota") {
			goles += 1; //goles = goles +1
			texto_marcador.text = goles + " Rosa";
		}
	}
}
