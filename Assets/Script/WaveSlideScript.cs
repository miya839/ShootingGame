using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSlideScript : MonoBehaviour {

	private Slider _slider;
	public Text wave;

	void Start()
	{
		_slider = this.gameObject.GetComponent<Slider>();
		float waveCount = _slider.value * 5f;
		
		MasterScript.gameWave = waveCount;
		wave.text = "Wave:" + (_slider.value * 5f).ToString("0");
	}
    

	public void OnValueChange()
	{
		MasterScript.gameWave = _slider.value * 5f;
		wave.text = "Wave:" + (_slider.value * 5f).ToString("0");
		Debug.Log(_slider.value * 5);
	}
}
