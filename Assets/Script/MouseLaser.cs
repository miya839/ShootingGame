using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class MouseLaser : MonoBehaviour
{
	public GameObject timer;
	public GameObject master;

	[SerializeField]
	private AudioClip gun;
	[SerializeField]
	private AudioClip btnclick;
	[SerializeField]
	private AudioClip hostage;
	
	private AudioSource audioSource;

	private void Start()
	{
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = gun;
	}

	// Update is called once per frame
    void Update() {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
	            
	            if(hit.collider.gameObject.layer != 5)
	            {
		            audioSource.clip = gun;
		            audioSource.Play();
	            }
	            
	            audioSource.clip = gun;
	            audioSource.Play();
	            
				Debug.Log(hit.collider.gameObject.tag);

	            Debug.Log(hit.collider.gameObject.name);
	            if (hit.collider.gameObject.name == "Hostage")
	            {
		            timer.GetComponent<TimerScript>().addTime();
		            master.GetComponent<MasterScript>().HostageHit();
		            audioSource.clip = hostage;
		            audioSource.Play();
					Destroy(hit.collider.gameObject);
	            }

	            if (hit.collider.gameObject.name == "Enemy")
	            {
		            master.GetComponent<MasterScript>().EnemyHit();
		            Destroy(hit.collider.gameObject);
	            }
            }
        }
	}
}
