using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    public float score;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine ("UpTime");
        score = 1000f;   
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    IEnumerator UpTime () {
		while(true){
			yield return new WaitForSeconds (1);
			score--;
		}
	}


}
