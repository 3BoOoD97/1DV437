using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManger : MonoBehaviour {
	public static AudioClip backgroundSound,die,coin,gameover,jump,splash;
	static AudioSource src;

	// Use this for initialization
	void Start () {
		
		die = Resources.Load<AudioClip> ("die");
		coin = Resources.Load<AudioClip> ("coin");
		gameover = Resources.Load<AudioClip> ("GameOver");
		jump = Resources.Load<AudioClip> ("jump");
		splash = Resources.Load<AudioClip> ("splash");
	
		src = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void PlaySound (string str){

		switch (str) {
		case "die":
			src.PlayOneShot (die);
			break;
		case "coin":
			src.PlayOneShot (coin);
			break;
		case "gameover":
			src.PlayOneShot (gameover);
			break;
		case "jump":
			src.PlayOneShot (jump);
			break;
		case "splash":
			src.PlayOneShot (splash);
			break;
		}
	}
}
