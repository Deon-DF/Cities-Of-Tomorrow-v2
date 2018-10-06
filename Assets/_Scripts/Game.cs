using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

	public static Game id;
	public Enum_Phase current_phase = Enum_Phase.phase_Event;
	public Enum_Menu current_menu = Enum_Menu.none;

	public Base player_base;
	public Controls controls;
	public City city;

	void initialize() {
		player_base = new Base ();
		city = new City ();
		controls = new Controls ();

		current_phase = Enum_Phase.phase_Event;
		current_menu = Enum_Menu.none;

		#region Load user preferences
		PlayerPrefs.id.load_player_settings ();
		GUI.id.update_settings_buttons_on_start ();
		#endregion
	}
	
	void Awake () {
		if (id == null) {
			id = this;
		} else {
			Debug.LogError ("Another instance of Game is already initialized!");
		}
	}

	void Start () {
		initialize ();		
	}

	void Update () {
		controls.hotkeys ();
	}
}
