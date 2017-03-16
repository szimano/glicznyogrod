using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;

	private AudioSource audioSource;

	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad(gameObject);
	}

	void Start() {
		audioSource = GetComponent<AudioSource>();
	}

	void OnLevelWasLoaded(int level) {
		AudioClip clip = levelMusicChangeArray[level];

		if (clip) {
			audioSource.Stop();
			audioSource.clip = clip;
			audioSource.Play();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeVolume(float volume) {
		audioSource.volume = volume;
	}
}
