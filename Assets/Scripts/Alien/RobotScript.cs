using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotScript : MonoBehaviour {
	Rigidbody2D eduardo;
	SpriteRenderer sprite_robot;

	public float velocidad;

	// Use this for initialization
	void Start () {
		eduardo = GetComponent<Rigidbody2D> ();
		sprite_robot = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			eduardo.velocity = new Vector2 (-velocidad, 0);
			sprite_robot.flipX = true;
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			eduardo.velocity = new Vector2 (velocidad, 0);
			sprite_robot.flipX = false;
		}
	}
}
