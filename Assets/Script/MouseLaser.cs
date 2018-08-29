using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class MouseLaser : MonoBehaviour
{
	public GameObject timer;
	public GameObject master;

    // Update is called once per frame
    void Update() {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Debug.Log(hit.collider.gameObject.name);
	            if (hit.collider.gameObject.name == "Hostage")
	            {
		            timer.GetComponent<TimerScript>().addTime();
		            master.GetComponent<MasterScript>().HostageHit();
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
