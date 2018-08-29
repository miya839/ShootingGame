using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScript : MonoBehaviour {
	
	public GameObject master;
	//public GameObject mainCamera;
	
	private bool _clickFlag;
	private float _seconds;
	private float _oldSeconds;

	void OnEnable()
	{
		_clickFlag = false;
		_seconds = 3.0f;
		_oldSeconds = 3.0f;
	}
	
	// Update is called once per frame
	void Update () {
		_seconds -= Time.deltaTime;
            
		if ((int) _seconds != (int) _oldSeconds)
		{
			this.GetComponentInChildren<Text>().text = _seconds.ToString("0");
		}
		_oldSeconds = _seconds;

		if (_seconds <= 0.0f)
		{
			master.SetActive(true);
			this.gameObject.SetActive(false);
		}
	}
}
