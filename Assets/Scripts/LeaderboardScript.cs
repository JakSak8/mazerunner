using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LeaderboardScript : MonoBehaviour
{
    public InputField playerName;
    public static string pName;
    public Text scoreText;
    float playerScore;

    public Text[] highScores;

    float [] highScoreValues;
    string [] highScoreNames;

    void Start() {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        highScoreValues = new float[5];
        highScoreNames = new string[5];

        for(int i = 0; i < highScores.Length; i++)
        {
            highScoreValues [i] =  PlayerPrefs.GetFloat("highScoreValues" + i);
            highScoreNames [i] = PlayerPrefs.GetString("highScoreNames" + i);
        }
        DisplayScores();
    }

    void DisplayScores()
    {
        for (int i = 0; i < highScores.Length; i++){
            highScores[i].text = highScoreValues[i].ToString() + " | " + highScoreNames[i];
        }
    }

    public void CheckHighScore(float time, string name){
        for (int i = 0; i < highScores.Length; i++)
        {
            if(time > highScoreValues[i])
            {
                for(int j = highScores.Length - 1; j > i; j--)
                {
                    highScoreValues[j] = highScoreValues[j - 1];
                    highScoreNames[j] = highScoreNames[j - 1];
                }
                highScoreValues[i] = time;
                highScoreNames[i] = name;
                DisplayScores();
                SaveScores();
                break;
            }
        }
    }
    
    void SaveScores()
    {
        for(int i = 0; i < highScores.Length; i++)
        {
            PlayerPrefs.SetFloat("highScoreValues" + i, highScoreValues[i]);
            PlayerPrefs.SetString("highScoreNames" + i, highScoreNames[i]);
        }
    }

    public void Submit() 
    {
        playerScore = PlayerPrefs.GetFloat("Score", 0.0f);

        pName = playerName.text;

        if (name == "" || name == null) {
            return;
        }

        CheckHighScore(playerScore, pName);

        SceneManager.LoadScene("HomePage");
    }

    public void GoBack() {
        SceneManager.LoadScene("HomePage");
    }
}
