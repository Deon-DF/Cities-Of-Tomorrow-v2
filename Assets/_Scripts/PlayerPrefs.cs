using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;


public class PlayerPrefs : MonoBehaviour {

	public static PlayerPrefs id;

	string settings_path = "PlayerPrefs.ini";

	public int sfx = 1;
	public int music = 1;


	public void load_player_settings() {
		List<string> player_preferences = FileManager.readFromTextFile (settings_path);

		foreach (string line in player_preferences) {
			string pattern_sfx = @"^sfx (\d)$";
			string pattern_music = @"^music (\d)$";
			Match match_sfx = Regex.Match (line, pattern_sfx);
			Match match_music = Regex.Match (line, pattern_music);

			// Is sfx enabled
			if (match_sfx.Success) {
				string result = match_sfx.Groups [1].ToString ();
				if (result == "1") { sfx = 1; } else { sfx = 0; }
			}
			// Is music enabled
			if (match_music.Success) {
				string result = match_music.Groups [1].ToString ();
				if (result == "1") { music = 1; } else { music = 0; }
			}
		}

	}


	public void save_player_settings() {
		FileManager.deleteFile (settings_path);
		FileManager.createPrefsFile (settings_path);
	}

	// Use this for initialization
	void Awake () {
		if (id == null) {
			id = this;
		} else {
			Debug.LogError ("Another instance of PlayerSettings is already initialized!");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
