using System.Collections;
using System.Collections.Generic;
﻿using UnityEngine;

public class VolumeChangeValue : MonoBehaviour {

	private AudioSource audioSrc;

	// Music volume variable that will be modified
	private float musicVolume = 1f;

	// Use this for initialization
	void Start () {
		audioSrc = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {

		// Setting volume option of Audio Source to be equal to musicVolume
		audioSrc.volume = musicVolume;
	}

	// sets musicValue
	public void SetVolume(float vol)
	{
		musicVolume = vol;
	}
}