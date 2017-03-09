using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;

	private AudioSource audio;

	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad(gameObject);
	}

	void Start() {
		audio = GetComponent<AudioSource>();
	}

	void OnLevelWasLoaded(int level) {
		audio.Stop();
		audio.clip = levelMusicChangeArray[level];
		audio.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
