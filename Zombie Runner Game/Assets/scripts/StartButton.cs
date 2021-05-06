using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {

	// Use this for initialization
	public void StartGame () {
		ScoreManger.instance.clearScore();
		SceneManager.LoadScene (1);
	}

	public void lvl1(){
		ScoreManger.instance.clearScore();
		SceneManager.LoadScene (1);
	}

	public void lvl2(){
		ScoreManger.instance.clearScore();
		SceneManager.LoadScene (2);
	}

	public void lvl3(){
		ScoreManger.instance.clearScore();
		SceneManager.LoadScene (3);
	}

	public void lvl4(){
		ScoreManger.instance.clearScore();
		SceneManager.LoadScene (4);
	}

}
