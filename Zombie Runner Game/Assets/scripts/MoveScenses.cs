using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MoveScenses : MonoBehaviour {
	[SerializeField] Text Timer ;
	float currentTime = 0f;
	float startTime = 30f;





	void Start(){
		currentTime = startTime;
		}





void Update(){
	
		int min = (int)currentTime / 60;
		int sec = (int)currentTime % 60;

		if (SceneManager.GetActiveScene ().buildIndex == 0) { 
			ScoreManger.instance.clearScore(); // When it is gameover delete the current score
		}
		if (sec < 0) { // Load next scene when the timer over
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

		currentTime -= 1 * Time.deltaTime; // Decrease the timer

		Timer.text = min.ToString () + " : " + sec.ToString (); // Show the minutes and seconds after decreaseing


}}




	
