using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class MasterScript : MonoBehaviour
{
	public GameObject[] target;
	private GameObject _InstantObject;
	//public GameObject mainCamera;
	public GameObject timer;

	public GameObject playPanel;
	public GameObject resultPanel;

	public GameObject wave;
	public GameObject hit;
	public GameObject miss;

	public GameObject resultTime;
	public GameObject resultHit;
	public GameObject resultMiss;
	
	public static int remainingcount;
	private int _TargetNum;

	private int _waveCount;
	private int _hitCount;
	private int _missCount;

	public static float targetDist;
	public static float gameWave;

	private string elapsedTime;

	// Use this for initialization
	public void OnEnable ()
	{
		playPanel.SetActive(true);
		
		remainingcount = 0;
		_InstantObject = null;

		_waveCount = 0;
		_hitCount = 0;
		_missCount = 0;
		hit.GetComponent<Text>().text = "Hit:0";
		miss.GetComponent<Text>().text = "Miss:0";
	}
	// Update is called once per frame
	void Update () {

		if (remainingcount == 0 && _waveCount == gameWave)
		{
			//mainCamera.GetComponent<MouseLaser>().enabled = false;
			elapsedTime = timer.GetComponent<TimerScript>().getTime();
			playPanel.SetActive(false);
			resultPanel.SetActive(true);
			resultTime.GetComponent<Text>().text = "Time:" + elapsedTime;
			resultHit.GetComponent<Text>().text = "Hit:" + _hitCount.ToString();
			resultMiss.GetComponent<Text>().text = "Miss:" + _missCount.ToString();
			Destroy(_InstantObject.gameObject);
			this.gameObject.SetActive(false);
		}
		
		if (remainingcount == 0 && _waveCount !=gameWave)
		{
			nextWave();
			if (_InstantObject != null)
			{
				Destroy(_InstantObject.gameObject);
			}
			_TargetNum = Random.Range(0, 7);
			_InstantObject = Instantiate(target[_TargetNum], new Vector3(0f, 0f, targetDist - 9f), Quaternion.identity);
			remainingcount = 3;
		}
		
	}


	public void nextWave()
	{
		_waveCount++;
		wave.GetComponent<Text>().text = "Wave:" + _waveCount.ToString();
	}
	
	public void EnemyHit()
	{
		_hitCount++;
		hit.GetComponent<Text>().text = "Hit:" + _hitCount.ToString();
	}

	public void HostageHit()
	{
		_missCount++;
		miss.GetComponent<Text>().text = "Miss:" + _missCount.ToString();
	}
}
