using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class begin : MonoBehaviour {
	public GameObject wall;
	// Use this for initialization
	void Start()
	{
		wall.SetActive(false);
	}

	void OnTriggerEnter()
	{
		wall.SetActive(true);
	}
}
