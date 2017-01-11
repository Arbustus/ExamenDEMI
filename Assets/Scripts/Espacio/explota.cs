using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explota : MonoBehaviour {
	public GameObject plataforma;
	public GameObject explosion;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col){
		Instantiate (explosion, transform.position, transform.rotation);
		Destroy (plataforma);
		Destroy (gameObject);
	}
}
