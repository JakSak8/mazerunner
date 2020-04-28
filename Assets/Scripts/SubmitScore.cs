using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SubmitScore : MonoBehaviour
{
    // public InputField playerName;
    // public static string pName;
    // public Text scoreText;
    // float playerScore;
    
    // private class HighScore
    // {
    //     public string name;
    //     public float score;

    //     public HighScore(string name, float score)
    //     {
    //         this.name = name;
    //         this.score = score;
    //     }
    // }

    void Awake()
    {
    }

    // void Start() {
    //     Cursor.lockState = CursorLockMode.None;
    //     Cursor.visible = true;

    //     playerScore = PlayerPrefs.GetFloat("Score", 0.0f);
    //     Debug.Log(playerScore);
    //     scoreText.text = "Score: " + playerScore.ToString();
    // }

    // public void Submit() 
    // {
    //     pName = playerName.text;

    //     HighScore newHS = new HighScore(pName, playerScore);

    //     float currentScore = PlayerPrefs.GetFloat("CurrentScore", 0.0f);

    //     string name = nameInputField.text;

    //     if (name == "" || name == null) {
    //         return;
    //     }

    //     List<Score> tempScores = new List<Score>();

    //     foreach (Score score in topScores) {
    //         tempScores.Add(score);
    //     }

    //     foreach (Score score in tempScores) {
    //         if (Mathf.Approximately(score.time, 0.0f)) {
    //             topScores.Remove(score);
    //         }
    //     }

    //     Score currentScoreObj = new Score(currentScore, name);
    //     topScores.Add(currentScoreObj);

    //     topScores.Sort((x, y) => x.time.CompareTo(y.time));

    //     int length = topScores.Count <= 5 ? topScores.Count : 5;

    //     for (int i = 0; i < length; i++) {
    //         highScores[i] = topScores[i].time;
    //         savedNames[i] = topScores[i].name;
    //     }

    //     for (int i = 0; i < 5; i++) {
    //         PlayerPrefs.SetFloat("HighScore" + i, highScores[i]);
    //         PlayerPrefs.SetString("HighName" + i, savedNames[i]);
    //     }

    //     // LeaderboardController.SubmitNewScore();
    //     SceneManager.LoadScene("HomePage");
    // }
}
