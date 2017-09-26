using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreenTimer : MonoBehaviour {

	public float splashTime = 5f;

	
	// Update is called once per frame
	void Update ()
	{
		splashTime -= Time.deltaTime;
		if (splashTime < 0) {
			GameObject.Find("LevelManager").GetComponent<LevelManager>().LoadLevel(1);
		} 
	}
}
