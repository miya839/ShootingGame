using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	void OnDestroy()
	{
		MasterScript.remainingcount--;
		Debug.Log(MasterScript.remainingcount);
	}
}
