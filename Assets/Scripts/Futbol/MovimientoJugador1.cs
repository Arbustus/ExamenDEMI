using UnityEngine;
using System.Collections;

public class MovimientoJugador1 : MonoBehaviour {

	public float velocidad = 5f;
	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D)) {
			MovimientoDerecha ();
		}

		if (Input.GetKey (KeyCode.A)) {
			MovimientoIzquierda ();
		}

		if (Input.GetKey (KeyCode.W)) {
			MovimientoArriba ();
		}

		if (Input.GetKey (KeyCode.S)) {
			MovimientoAbajo ();
		}
	}

	void MovimientoDerecha(){
		rb.velocity = new Vector2(velocidad, rb.velocity.y);
	}

	void MovimientoIzquierda() {
		rb.velocity = new Vector2 (-velocidad, rb.velocity.y);
	}

	void MovimientoArriba(){
		rb.velocity = new Vector2(rb.velocity.x, velocidad);
	}

	void MovimientoAbajo() {
		rb.velocity = new Vector2 (rb.velocity.x, -velocidad);
	}
}
