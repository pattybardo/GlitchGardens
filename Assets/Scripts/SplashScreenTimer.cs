using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreenTimer : MonoBehaviour {

	public float splashTime = 5f;

	public bool autoLoad = true;

	
	// Update is called once per frame
	void Update ()
	{
		splashTime -= Time.deltaTime;
		if (autoLoad) {
			if (splashTime < 0) {
				GameObject.Find ("LevelManager").GetComponent<LevelManager> ().LoadLevel (1);
			} 
		} else {
			Debug.Log("Autoload has been disabled");
		}
	}
}
