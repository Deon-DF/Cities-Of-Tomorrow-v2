using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour {

	public static GlobalVariables id;

	public int max_security = 100;

	// Use this for initialization
	void Start () {
		if (id == null) {
			id = this;
		} else {
			Debug.LogError ("Another instance of Settings is already initialized!");
		}
	}
}
