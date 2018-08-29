﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class ModeButtonScript : MonoBehaviour
{
	public Button Normalbtn;
	public Button Hardbtn;
	
	[SerializeField]
	private Color _btnColorR = Color.red;
	[SerializeField]
	private Color _btnColorB = Color.blue;

	// Use this for initialization
	void Start () {
		Normalbtn.image.color = _btnColorB;
		Hardbtn.image.color = _btnColorB;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onClick()
	{
		switch (transform.name)
		{
		case "NormalButton":
			Normalbtn.image.color = _btnColorR;
			Hardbtn.image.color = _btnColorB;	
			break;
		case "HardButton":
			Normalbtn.image.color = _btnColorB;
			Hardbtn.image.color = _btnColorR;
			break;
				
		}
	}
}
