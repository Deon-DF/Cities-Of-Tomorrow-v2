using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


public class Base {
	Level level;

	public int max_security = GlobalVariables.id.max_security;
	int _security = GlobalVariables.id.max_security;

	int _notoriety_social;
	int _notoriety_tech;
	int _notoriety_rogue;
	int _notoriety_force;

	public void decreaseSecurity(int social, int tech, int rogue, int force) {
		_notoriety_social += social;
		_notoriety_tech += tech;
		_notoriety_rogue += rogue;
		_notoriety_force += force;
	}

	public int security {
		get {
			int current_security = max_security - _notoriety_social - _notoriety_tech - _notoriety_rogue - _notoriety_force;
			if (current_security <= 0) {
				// End game
				return Math.Max(current_security, 0);
			} else return Math.Max(current_security, 0);
		}
	}
}

public class Character {
	public bool protagonist = false;
	public string first_name = "name";
	public string second_name = "surname";
	public int age = 20;

	public int might = 1;
	public int dexterity = 1;
	public int charisma = 1;
	public int intelligence = 1;
}

public class City {

	public string name;
	public List<Level> levels = new List<Level>();


	public City() {
		add_city_levels ();
	}

	void add_city_levels () {
		Debug.Log ("Populating the city with levels");
		for (int i = 1; i <= 5; i++) {
			Level level = new Level ();
			level.generate_levels (i);
			levels.Add (level);
		}
	}
}

public class Level {
	public string name;
	public int height = 0;
	public List<Location> locations = new List<Location>();


	public void generate_levels(int i) {
		Debug.Log ("Generating new level: " + i);
		switch (i) {
		case 1:
			name = "1st level";
			height = 1;
			locations = Location.generate_locations (1);
			break;
		case 2:
			name = "2nd level";
			height = 2;
			locations = Location.generate_locations (2);
			break;
		case 3:
			name = "3rd level";
			height = 3;
			locations = Location.generate_locations (3);
			break;
		case 4:
			name = "4th level";
			height = 4;
			locations = Location.generate_locations (4);
			break;
		case 5:
			name = "5th level";
			height = 5;
			locations = Location.generate_locations (5);
			break;
		default:
			name = "Unknown level";
			height = 0;
			Debug.LogError ("Tried to generate a level with an inappropriate number: " + i);
			break;
		}
	}
}

public class Location {
	public string name = "";
	public List<Encounter> encounters;
	public int security_level = 0;

	public static List<Location> generate_locations(int i) {
		Debug.Log ("Generating locations for the level " + i + ".");

		switch (i) {

		case 1:
			Location location1_1 = new Location ();
			Location location1_2 = new Location ();
			Location location1_3 = new Location ();
			List<Location> list1 = new List<Location> ();

			location1_1.name = "Town Hall";
			location1_2.name = "Police Station";
			location1_3.name = "Courthouse";

			list1.Add(location1_1);
			list1.Add(location1_2);
			list1.Add(location1_3);

			return list1;

		case 2:
			Location location2_1 = new Location ();
			Location location2_2 = new Location ();
			Location location2_3 = new Location ();
			List<Location> list2 = new List<Location>();

			location2_1.name = "Media Center";
			location2_2.name = "Hospital";
			location2_3.name = "Campus";

			list2.Add(location2_1);
			list2.Add(location2_2);
			list2.Add(location2_3);

			return list2;

		case 3:
			Location apartments = new Location ();
			Location leisure = new Location ();
			Location citypark = new Location ();
			List<Location> level3 = new List<Location>();

			apartments.name = "Apartments";
			leisure.name = "Leisure District";
			citypark.name = "City Park";

			level3.Add(apartments);
			level3.Add(leisure);
			level3.Add(citypark);

			return level3;

		case 4:
			Location location4_1 = new Location ();
			Location location4_2 = new Location ();
			Location location4_3 = new Location ();
			List<Location> list4 = new List<Location>();

			location4_1.name = "Machinery";
			location4_2.name = "Power station";
			location4_3.name = "Sewers";

			list4.Add(location4_1);
			list4.Add(location4_2);
			list4.Add(location4_3);

			return list4;

		case 5:
			Location location5_1 = new Location ();
			Location location5_2 = new Location ();
			Location location5_3 = new Location ();
			List<Location> list5 = new List<Location>();

			location5_1.name = "Garbage Dump";
			location5_2.name = "Slums";
			location5_3.name = "Old Warehouses";

			list5.Add(location5_1);
			list5.Add(location5_2);
			list5.Add(location5_3);

			return list5;

		default:
			Debug.LogError("Incorrect level specified to generate locations: " + i);
			return null;

		}

	}
}

public class Encounter {
	string name;
	string _description;

	List<Choice> choices;
}

public class Choice {
	string _text;
	int _difficulty;
	bool _escapable;

	int _cost_social;
	int _cost_tech;
	int _cost_rogue;
	int _cost_force;
}

public enum Enum_Phase {phase_Event, phase_Opportunity, phase_Feedback, phase_Deployment}

public enum Enum_Menu {none, main, esc, settings}
public enum Enum_Level { level1, level2, level3, level4, level5}

