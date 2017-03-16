using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

	public Slider volumeSlider;

	public Slider difficultySlider;

	public LevelManager levelManager;

	private MusicManager musicMangager;

	// Use this for initialization
	void Start () {
		musicMangager = GameObject.FindObjectOfType<MusicManager>();	

		volumeSlider.value = GlitchPlayerPrefs.GetMasterVolume();
		difficultySlider.value = GlitchPlayerPrefs.GetDifficulty();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(volumeSlider.value);
		musicMangager.ChangeVolume(volumeSlider.value);	
	}

	public void SaveAndExit() {
		GlitchPlayerPrefs.SetMasterVolume(volumeSlider.value);
		GlitchPlayerPrefs.SetDifficulty(difficultySlider.value);
		levelManager.LoadLevel("01a Start");
	}

	public void SetDefault() {
		volumeSlider.value = 0.8f;
		difficultySlider.value = 2f;
	}
}
