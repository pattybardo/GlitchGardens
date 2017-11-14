using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;

	private AudioSource audioSource;

	static MusicManager instance = null;

	void Awake ()
	{
		DontDestroyOnLoad(gameObject);
	}

	void Start ()
	{
		if (instance != null && instance !=this) {
			Destroy (gameObject);
			print ("Duplicate music player self-destructing!");
		} else {
			instance = this;
			audioSource = GetComponent<AudioSource> ();
			audioSource.clip = levelMusicChangeArray [0];
			audioSource.loop = true;
			audioSource.Play ();
		}
	}

	void OnEnable()
     {
      //Tell our 'OnLevelFinishedLoading' function to start listening for a scene change as soon as this script is enabled.
         SceneManager.sceneLoaded += OnLevelFinishedLoading;
     }
         
     void OnDisable()
     {
     //Tell our 'OnLevelFinishedLoading' function to stop listening for a scene change as soon as this script is disabled. Remember to always have an unsubscription for every delegate you subscribe to!
         SceneManager.sceneLoaded -= OnLevelFinishedLoading;
     }
 
     void OnLevelFinishedLoading (Scene scene, LoadSceneMode mode)
	{
		Debug.Log ("Level Loaded: " + scene.buildIndex);
		if (scene.buildIndex == 0) {
			audioSource = GetComponent<AudioSource> ();
		}
		if (levelMusicChangeArray [scene.buildIndex]) {
			audioSource.clip = levelMusicChangeArray [scene.buildIndex];
			audioSource.loop = true;
			audioSource.Play ();
		} else {
			Debug.Log("Missing AudioClip at index: " + scene.buildIndex);
		}

     }
}
