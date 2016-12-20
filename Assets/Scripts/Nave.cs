using UnityEngine;
using System.Collections;

public class Nave : MonoBehaviour {
	private Rigidbody2D rb;
	public float fuerza;
	void Start(){
		rb = GetComponent<Rigidbody2D> ();
	}

	void Update(){
		if (Input.GetKey (KeyCode.UpArrow)) {
			rb.AddForce (Vector2.up * fuerza);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			rb.AddForce (Vector2.right * fuerza);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			rb.AddForce (Vector2.right * -fuerza);
		}
	}
	void OnCollisionEnter2D (Collision2D col){
		if(col.gameObject.tag == "muerte"){
			Destroy(gameObject);
		}
	}

}
