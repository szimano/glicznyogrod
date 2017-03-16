﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlitchPlayerPrefs : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_";

	public static void SetMasterVolume(float volume) {
		if (volume > 0f && volume < 1f) {
			PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
		} else {
			Debug.LogError ("Master volume out of range");
		}
	}

	public static float GetMasterVolume() {
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}

	public static void UnlockLevel (int level) {
		if (level <= SceneManager.sceneCount - 1) {
			PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1);
		} else {
			Debug.LogError ("Trying to unlock wrong level: "+level);
		}
	}

	public static bool IsLevelUnlocked(int level) {
		if (level <= SceneManager.sceneCount - 1) {
			if (PlayerPrefs.HasKey(LEVEL_KEY + level) && PlayerPrefs.GetInt(LEVEL_KEY + level) == 1) {
				return true;
			}
		} else {
			Debug.LogError ("Trying to check unlocked wrong level: "+level);
		}
		return false;
	} 

	public static void SetDifficulty(float difficulty) {
		if (difficulty > 0f && difficulty < 1f) {
			PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
		} else {
			Debug.LogError ("Difficulty out of range");
		}	
	}

	public static float GetDifficulty() {
		return PlayerPrefs.GetFloat (DIFFICULTY_KEY);
	}
}
