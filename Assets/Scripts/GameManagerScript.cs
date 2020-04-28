using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour {

	public GameObject Sphere;
	public bool finished = false;
	public ScoreScript scoreScript;
	public GameObject PauseMenu;

	void Awake () { 
		scoreScript = GetComponent<ScoreScript>();
	}

	// Use this for initialization
	void Start () {
		hidePaused();
		Time.timeScale = 1;
	}

	// Update is called once per frame
	void Update () {
		if(finished)
		{
			PlayerPrefs.SetFloat("Score", scoreScript.score);
			Debug.Log(scoreScript.score);
			SceneManager.LoadScene("Leaderboard");
			return;
		}

		if(Input.GetKeyDown("escape"))
		{
			if (Time.timeScale == 1) 
			{
				Time.timeScale = 0;
				showPaused ();
			} else 
			{
				Time.timeScale = 1;
				hidePaused ();
			}
		}

		if(Time.timeScale == 0){
			if(Input.GetKeyDown("1"))
			{
				Restart();
			}

			if(Input.GetKeyDown("2"))
			{
				MainMenu();
			}
		}
	}

	//shows objects with ShowOnPause tag
	public void showPaused () {
		PauseMenu.SetActive (true);
	}

	//hides objects with ShowOnPause tag
	public void hidePaused () {
		PauseMenu.SetActive (false);
	}

	public void Restart () {
		SceneManager.LoadScene ("Scene1");
	}

	public void MainMenu () {
		SceneManager.LoadScene ("HomePage");
	}

	public void GameOver() {
		finished = true;
	}
}