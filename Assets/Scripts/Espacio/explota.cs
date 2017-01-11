using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explota : MonoBehaviour {
	public GameObject plataforma;
	public GameObject explosion;
	public Animator panel_reiniciar;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter2D(Collision2D col){
		panel_reiniciar.SetBool ("Visible", true);
		Instantiate (explosion, transform.position, transform.rotation);
		Destroy (plataforma);
		Destroy (gameObject);
	}
}
