using UnityEngine;
using System.Collections;

public class Nave : MonoBehaviour {
	private Rigidbody2D rb;
	public float fuerza;
	public float rotacion;
	public GameObject muerte;

	void Start(){
		rb = GetComponent<Rigidbody2D> ();
	}

	void Update(){
		if (Input.GetKey (KeyCode.UpArrow)) {
			rb.AddForce (Vector2.up * fuerza);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			rb.AddTorque (-rotacion);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			rb.AddTorque(rotacion);
		}
	}
	void OnCollisionEnter2D (Collision2D col){
		if(col.gameObject.tag == "muerte"){
			Instantiate (muerte, transform.position, transform.rotation);
			Destroy(gameObject);
		}
	}

}
