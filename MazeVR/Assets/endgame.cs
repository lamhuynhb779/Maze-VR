using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endgame : MonoBehaviour {
	public GameObject winText;
	void Start()
	{		
		winText.SetActive(false);
	}
	
	void OnTriggerEnter()
	{
		winText.SetActive(true);
	}
	
}
	
