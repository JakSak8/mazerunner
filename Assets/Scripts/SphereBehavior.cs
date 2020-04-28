using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SphereBehavior : MonoBehaviour
{
    public GameManagerScript manager;
    // public SubmitScoreScript = SS;

    void Awake()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManagerScript> ();
        //SS = GameObject.Find("SubmitScore").getComponent<SubmitScore>();
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {
			manager.GameOver();
		}
    }
}
