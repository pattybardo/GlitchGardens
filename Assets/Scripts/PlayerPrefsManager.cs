﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour {


	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_";

	public static void SetMasterVolume (float volume)
	{
		if (volume > 0f && volume < 1f) {
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume);
		} else {
			Debug.LogError ("Master volume out of range");
		}


	}

	public static float GetMasterVolume () {
		return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
	}

	public static void UnlockLevel (int level)
	{
		if (level <= SceneManager.sceneCountInBuildSettings - 1) {
			PlayerPrefs.SetInt (LEVEL_KEY + level.ToString(), 1); // Use 1 for true
		} else {
			Debug.LogError("PlayerPrefsManager: Trying to unlock level not in build order");
		}

	}

	public static bool IsLevelUnlocked (int level)
	{
		if (level <= SceneManager.sceneCountInBuildSettings - 1) {
			int levelValidity = PlayerPrefs.GetInt (LEVEL_KEY + level.ToString ());
			bool isLevelUnlocked = (levelValidity == 1);
			return isLevelUnlocked;
		} else {
			Debug.LogError("PlayerPrefsManager: Level not in build order");
			return false;
		}

	}

	public static void SetDifficulty (float difficulty)
	{
		if (difficulty >= 1f && difficulty <= 3f) {
			PlayerPrefs.SetFloat (DIFFICULTY_KEY, difficulty);
			Debug.Log("PlayerPrefsManager: Difficulty set to: " + difficulty);
		} else {
			Debug.LogError("PlayerPrefsManager: Difficulty out of range");
		}
	}

	public static float GetDifficulty () {
		return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
	}
}
