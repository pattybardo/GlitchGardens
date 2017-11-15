using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour {

	// Use this for initialization
	void Start () {


		print("Difficulty is set to : " + PlayerPrefsManager.GetDifficulty());


	}
}
