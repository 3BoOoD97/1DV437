using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
	public PlayerController controller;
	float hMove = 0f;
	public float runSpeed = 40f;
	bool jump = false;
	public Animator animotor;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		animotor.SetFloat ("speedRight",Mathf.Abs( hMove));
		hMove=Input.GetAxisRaw ("Horizontal") * runSpeed;

		if (Input.GetButtonDown ("Jump")) { // If the player jump, play jump sound and jump animation 
			SoundManger.PlaySound ("jump");
			jump = true;
			animotor.SetBool ("Jumping", true);
		}
	}

	public void Landing(){
		animotor.SetBool ("Jumping", false); // when the player landing stop jump animation
	}

	void FixedUpdate(){
		controller.Move (hMove * Time.fixedDeltaTime, false, jump);
		jump = false;
		//animotor.SetFloat ("Jump",0);

	}
}
