using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

	public Slider volumeSlider;
	public Slider difficultySlider;
	public LevelManager levelManager;

	private float defaultVolume = 0.5f;
	private float defaultDifficulty = 1f;

	private MusicManager musicManager;

	void Start () {
		musicManager = GameObject.FindObjectOfType<MusicManager>();
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
		difficultySlider.value = PlayerPrefsManager.GetDifficulty();
	}

	void Update () {
		musicManager.ChangeVolume (volumeSlider.value);
	}

	public void ApplyDefault () {
		PlayerPrefsManager.SetMasterVolume(defaultVolume);
		PlayerPrefsManager.SetDifficulty(defaultDifficulty);
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
		difficultySlider.value = PlayerPrefsManager.GetDifficulty();
	}

	public void Back () {
		// This is implemented to set the volume back to the playPrefs if the user did not 
		// apply their changes before going back to the start menu
		PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
		PlayerPrefsManager.SetDifficulty(difficultySlider.value);
		levelManager.LoadLevel(1);


	}
}
