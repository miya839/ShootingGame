using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostageScript : MonoBehaviour {

	private float time;
	private TimerScript script;

	void Start()
	{
		MasterScript.remainingcount -= 1;
		Debug.Log(MasterScript.remainingcount);
	}
}
