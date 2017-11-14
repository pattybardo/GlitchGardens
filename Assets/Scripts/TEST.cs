using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefsManager.UnlockLevel(1);
		print(PlayerPrefsManager.IsLevelUnlocked(1));
		print(PlayerPrefsManager.IsLevelUnlocked(2));
		PlayerPrefsManager.UnlockLevel(2);
		print(PlayerPrefsManager.IsLevelUnlocked(2));
		PlayerPrefsManager.UnlockLevel(1);
		print(PlayerPrefsManager.IsLevelUnlocked(1));

		print(PlayerPrefsManager.GetDifficulty());
		PlayerPrefsManager.SetDifficulty(23);
		print(PlayerPrefsManager.GetDifficulty());



	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
