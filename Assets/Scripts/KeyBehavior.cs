using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehavior : MonoBehaviour {

	public float rotateSpeed = 5f;
	public GameObject Door;
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate (Vector3.up * rotateSpeed);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			Destroy (gameObject);
			Door.SetActive(false);
		}
	}	
}
