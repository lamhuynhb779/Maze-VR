using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rendercommand : MonoBehaviour {

	// Use this for initialization
	Transform mainCamTransform; //Stores the FPS camera transform
	private bool visible = true;
	public float distanceToAppear = 20;
	Renderer objRenderer;

	void Start()
	{
		mainCamTransform = Camera.main.transform;//Get camera transform reference
		objRenderer = gameObject.GetComponent<Renderer>(); //Get render reference
	}

	// Update is called once per frame
	void Update()
	{
		disappearChecker();
	}

	void disappearChecker()
	{
		float distance = Vector3.Distance(mainCamTransform.position, transform.position);

		//We have reached the distance to Enable Object
		if (distance < distanceToAppear)
		{
			if (!visible)
			{
				objRenderer.enabled = true;// Show Object
				visible = true;
				Debug.Log("Visible");
			}
		}

		else
		{
			if (visible)
			{
				objRenderer.enabled = false;// Hide Object
				visible = false;
				Debug.Log("InVisible");
			}
		}
	}
}
