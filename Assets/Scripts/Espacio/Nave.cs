using UnityEngine;
using System.Collections;

public class Nave : MonoBehaviour {
	private Rigidbody2D rb;
	public float fuerza = 15f;
	public float rotacion;
	public GameObject muerte;

	void Start(){
		rb = GetComponent<Rigidbody2D> ();
	}

	void Update(){
		if (Input.GetKey (KeyCode.UpArrow)) {
			rb.AddForce (transform.up * fuerza);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			rb.AddTorque (-rotacion/2);
			rb.AddForce (Vector2.up * fuerza/3);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			rb.AddTorque(rotacion/2);
			rb.AddForce (Vector2.up * fuerza/3);
		}
	}
}
