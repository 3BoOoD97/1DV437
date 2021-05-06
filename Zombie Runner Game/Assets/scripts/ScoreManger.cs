using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManger : MonoBehaviour {
	public static ScoreManger instance; 
	public Text currentScore, highestScoretxt, newScore;
	public static int score, highestScore;

	private void Awake(){
		instance = this;
		currentScore.text = "X" + score.ToString ();
		highestScoretxt.text = "X" + highestScore.ToString ();
		//channgeScore ();
			}

	
	public void channgeScore()
	{
			score++;
		updateHighScore ();
	
		currentScore.text = "X" + score.ToString ();
		highestScoretxt.text = "X" + highestScore.ToString ();
	}


	public void updateHighScore(){
		if (score > highestScore) {// Compare the current score with the highest score and if it is bigger then print the new high score and replace the highest high score with the current one
			newScore.text = "New High Score";
			highestScore = score;
			int num = (SceneManager.GetActiveScene ().buildIndex);
			if (num == 0) {
				newScore.text = "Congratulations You have Scored a New High Score"; // When it is a game over and the player scored a new high score then print this

			}
		}
	}

	public void clearScore(){

		score = 0;
	}

}
