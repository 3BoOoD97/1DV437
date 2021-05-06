using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class one : MonoBehaviour {
	public float speed = 1;
	private Rigidbody2D Rigid;
	public Animator animator;
	public
	// Use this for initialization
	void Start () {
		Rigid = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetAxisRaw ("Horizontal") > 0) {
			Rigid.velocity = new Vector2 (speed, 0);
			animator.SetFloat ("Speed", 1);

		} else if (Input.GetAxisRaw ("Horizontal") < 0) {
			Rigid.velocity = new Vector2 (speed*-1, 0);
					}
		else {
			Rigid.velocity = new Vector2 (0, 0);
		//	transform.position = new Vector3 (transform.position.x, -0.69f, 0);
		}

	}
	}

