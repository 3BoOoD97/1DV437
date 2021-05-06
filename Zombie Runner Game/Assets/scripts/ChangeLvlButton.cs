using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLvlButton : MonoBehaviour {

	public void changeLvl(){
		SceneManager.LoadScene (6);
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

	public void back(){
		ScoreManger.instance.clearScore();
		SceneManager.LoadScene (7);

	}
}
