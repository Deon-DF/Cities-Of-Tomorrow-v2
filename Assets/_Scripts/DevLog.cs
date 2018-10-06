using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DevLog {
	public static void displayLevels() {

		foreach (Level level in Game.id.city.levels) {
			string output = "";
			output += " " + level.name + ": | ";

			foreach (Location location in level.locations) {
				output += location.name + " | ";
			}

			Debug.Log (output);
		}
	}
}
