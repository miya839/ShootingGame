using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{

	[SerializeField] private int minutes;
	[SerializeField] private float seconds;


	private float oldSeconds;
	private Text timerText;
	
	// Use this for initialization
	private void OnEnable()
	{
		minutes = 0;
		seconds = 0f;
		oldSeconds = 0f;
		timerText = GetComponentInChildren<Text>();
	}
	
	// Update is called once per frame
	void Update()
	{
		seconds += Time.deltaTime;
		if (seconds >= 60.0f)
		{
			minutes++;
			seconds = seconds - 60.0f;
		}
		timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00.00");
	}

	public void addTime()
	{
		seconds += 10f;
	}

	public string getTime()
	{
		return minutes.ToString("00") + ":" + seconds.ToString("00.00");;
	}
	
	
}
