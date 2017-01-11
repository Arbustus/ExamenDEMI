using UnityEngine;
using System.Collections;

public class MovimientoJugador2 : MonoBehaviour {

	public float velocidad = 5f;
	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			MovimientoDerecha ();
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			MovimientoIzquierda ();
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			MovimientoArriba ();
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
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
