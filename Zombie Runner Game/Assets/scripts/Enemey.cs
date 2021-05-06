using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemey : MonoBehaviour {
	public float speed;
	private Transform target;
	public GameObject tar;
	// Use this for initialization
	void Start () {
		target = tar.GetComponent<Transform>();

		//target = tar.FindWithTag ("Player").GetComponent<Transform> ();
		//target = tar.f
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = Vector2.MoveTowards (transform.position, target.position , speed * Time.deltaTime);
	}
}
