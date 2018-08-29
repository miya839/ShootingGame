using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DestroyTime : MonoBehaviour {

    private float time;
    public GameObject timer;
    private TimerScript script;

	// Use this for initialization
	void Start () {
		
	}
    void OnEnable()
    {
        time = DateTime.Now.Hour * 60 * 60 * 1000 + DateTime.Now.Minute * 60 * 1000 + DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
    }

    void OnDestroy()
    {
        Debug.Log(time); 
        script = timer.GetComponent<TimerScript>();
        script.addTime();
    }

}
