using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{

	private AudioSource _audioSource;

	[SerializeField] private AudioClip _buttonClick;
	[SerializeField] private AudioClip _countDown;

	private void Start()
	{
		_audioSource = gameObject.GetComponent<AudioSource>();
	}

	public void ButtonClick()
	{
		_audioSource.clip = _buttonClick;
		_audioSource.Play();
	}

	public void CountDown()
	{
		_audioSource.clip = _countDown;
		_audioSource.Play();
	}
}
