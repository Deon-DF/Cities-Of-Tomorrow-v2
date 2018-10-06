using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls {

	public void hotkeys() {
		if (Input.GetKeyDown (KeyCode.L)) {
			DevLog.displayLevels ();
		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (Game.id.current_menu == Enum_Menu.none) {
				GUI.id.menu.escape_menu.gameObject.SetActive (true);
				Game.id.current_menu = Enum_Menu.esc;
			} else if (Game.id.current_menu == Enum_Menu.esc) {
				GUI.id.menu.escape_menu.gameObject.SetActive (false);
				Game.id.current_menu = Enum_Menu.none;
			} else if (Game.id.current_menu == Enum_Menu.settings) {
				GUI.id.menu.settings_menu.gameObject.SetActive (false);
				GUI.id.menu.escape_menu.gameObject.SetActive (true);
				Game.id.current_menu = Enum_Menu.esc;
				PlayerPrefs.id.save_player_settings ();
			}
		}
	}

	public void game_settings() {
	}
}
