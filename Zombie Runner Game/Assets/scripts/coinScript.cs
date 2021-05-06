using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : MonoBehaviour {

	public int coinValue = 1;

	private void OnTriggerEnter2D(Collider2D col){

		if (col.gameObject.CompareTag ("Player")) {
			ScoreManger.instance.channgeScore ();
		}
	}



}
