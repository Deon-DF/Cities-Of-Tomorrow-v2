using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Events {

	public static void generate_location_event (string location_name) {

		switch (location_name) {
		case "apartments":
			GUI.id.event_view.location_name.text = "Apartments";

			generate_apartments_event ();
			break;
		case "leisure":
			GUI.id.event_view.location_name.text = "Leisure district";

			generate_leisure_event ();
			break;
		case "city park":

			generate_park_event ();
			break;
		}

	}

	#region Level 3

	public static void generate_apartments_event() {
		int eventid = Random.Range (0, 4);

		switch (eventid) {
		case 0:
			GUI.id.event_view.location_name.text = Game.id.city.levels [2].locations [0].name;
			GUI.id.event_view.graphic.sprite = Resources.Load<Sprite> ("Images/Events/apartments_default");
			GUI.id.event_view.description.text = "The area is empty.";
			GUI.id.event_view.choice1.transform.Find ("Text").GetComponent<Text>().text = "Go on rampage!";
			GUI.id.event_view.choice2.transform.Find ("Text").GetComponent<Text>().text = "Find recruitment opportunities.";
			GUI.id.event_view.choice3.transform.Find ("Text").GetComponent<Text>().text = "Hack apartment security.";
			GUI.id.event_view.choice4.transform.Find ("Text").GetComponent<Text>().text = "Obtain funds illegally.";
			break;
		case 1:
			GUI.id.event_view.location_name.text = Game.id.city.levels [2].locations [0].name;
			GUI.id.event_view.graphic.sprite = Resources.Load<Sprite> ("Images/Events/apartments_default");
			GUI.id.event_view.description.text = "The area is empty.";
			GUI.id.event_view.choice1.transform.Find ("Text").GetComponent<Text>().text = "Go on rampage!";
			GUI.id.event_view.choice2.transform.Find ("Text").GetComponent<Text>().text = "Find recruitment opportunities.";
			GUI.id.event_view.choice3.transform.Find ("Text").GetComponent<Text>().text = "Hack apartment security.";
			GUI.id.event_view.choice4.transform.Find ("Text").GetComponent<Text>().text = "Obtain funds illegally.";
			break;
		case 2:
			GUI.id.event_view.location_name.text = Game.id.city.levels [2].locations [0].name;
			GUI.id.event_view.graphic.sprite = Resources.Load<Sprite> ("Images/Events/apartments_default");
			GUI.id.event_view.description.text = "The area is empty.";
			GUI.id.event_view.choice1.transform.Find ("Text").GetComponent<Text>().text = "Go on rampage!";
			GUI.id.event_view.choice2.transform.Find ("Text").GetComponent<Text>().text = "Find recruitment opportunities.";
			GUI.id.event_view.choice3.transform.Find ("Text").GetComponent<Text>().text = "Hack apartment security.";
			GUI.id.event_view.choice4.transform.Find ("Text").GetComponent<Text>().text = "Obtain funds illegally.";
			break;
		case 3:
			GUI.id.event_view.location_name.text = Game.id.city.levels [2].locations [0].name;
			GUI.id.event_view.graphic.sprite = Resources.Load<Sprite> ("Images/Events/apartments_default");
			GUI.id.event_view.description.text = "The area is empty.";
			GUI.id.event_view.choice1.transform.Find ("Text").GetComponent<Text>().text = "Go on rampage!";
			GUI.id.event_view.choice2.transform.Find ("Text").GetComponent<Text>().text = "Find recruitment opportunities.";
			GUI.id.event_view.choice3.transform.Find ("Text").GetComponent<Text>().text = "Hack apartment security.";
			GUI.id.event_view.choice4.transform.Find ("Text").GetComponent<Text>().text = "Obtain funds illegally.";
			break;
		}
	}

	public static void generate_leisure_event() {
		int eventid = Random.Range (0, 4);

		switch (eventid) {
		case 0:
			GUI.id.event_view.location_name.text = Game.id.city.levels [2].locations [1].name;
			GUI.id.event_view.graphic.sprite = Resources.Load<Sprite> ("Images/Events/leisure_default");
			GUI.id.event_view.description.text = "The area is empty.";
			GUI.id.event_view.choice1.transform.Find ("Text").GetComponent<Text>().text = "Go on rampage!";
			GUI.id.event_view.choice2.transform.Find ("Text").GetComponent<Text>().text = "Find recruitment opportunities.";
			GUI.id.event_view.choice3.transform.Find ("Text").GetComponent<Text>().text = "Hack consumer network.";
			GUI.id.event_view.choice4.transform.Find ("Text").GetComponent<Text>().text = "Obtain funds illegally.";
			break;
		case 1:
			GUI.id.event_view.location_name.text = Game.id.city.levels [2].locations [1].name;
			GUI.id.event_view.graphic.sprite = Resources.Load<Sprite> ("Images/Events/leisure_default");
			GUI.id.event_view.description.text = "The area is empty.";
			GUI.id.event_view.choice1.transform.Find ("Text").GetComponent<Text>().text = "Go on rampage!";
			GUI.id.event_view.choice2.transform.Find ("Text").GetComponent<Text>().text = "Find recruitment opportunities.";
			GUI.id.event_view.choice3.transform.Find ("Text").GetComponent<Text>().text = "Hack consumer network.";
			GUI.id.event_view.choice4.transform.Find ("Text").GetComponent<Text>().text = "Obtain funds illegally.";
			break;
		case 2:
			GUI.id.event_view.location_name.text = Game.id.city.levels [2].locations [1].name;
			GUI.id.event_view.graphic.sprite = Resources.Load<Sprite> ("Images/Events/leisure_default");
			GUI.id.event_view.description.text = "The area is empty.";
			GUI.id.event_view.choice1.transform.Find ("Text").GetComponent<Text>().text = "Go on rampage!";
			GUI.id.event_view.choice2.transform.Find ("Text").GetComponent<Text>().text = "Find recruitment opportunities.";
			GUI.id.event_view.choice3.transform.Find ("Text").GetComponent<Text>().text = "Hack consumer network.";
			GUI.id.event_view.choice4.transform.Find ("Text").GetComponent<Text>().text = "Obtain funds illegally.";
			break;
		case 3:
			GUI.id.event_view.location_name.text = Game.id.city.levels [2].locations [1].name;
			GUI.id.event_view.graphic.sprite = Resources.Load<Sprite> ("Images/Events/leisure_default");
			GUI.id.event_view.description.text = "The area is empty.";
			GUI.id.event_view.choice1.transform.Find ("Text").GetComponent<Text>().text = "Go on rampage!";
			GUI.id.event_view.choice2.transform.Find ("Text").GetComponent<Text>().text = "Find recruitment opportunities.";
			GUI.id.event_view.choice3.transform.Find ("Text").GetComponent<Text>().text = "Hack consumer network.";
			GUI.id.event_view.choice4.transform.Find ("Text").GetComponent<Text>().text = "Obtain funds illegally.";
			break;
		}
	}

	public static void generate_park_event() {

		int eventid = Random.Range (0, 4);

		switch (eventid) {
		case 0:
			GUI.id.event_view.location_name.text = Game.id.city.levels [2].locations [2].name;
			GUI.id.event_view.graphic.sprite = Resources.Load<Sprite> ("Images/Events/citypark_default");
			GUI.id.event_view.description.text = "The city park is quiet.";
			GUI.id.event_view.choice1.transform.Find ("Text").GetComponent<Text>().text = "Go on rampage!";
			GUI.id.event_view.choice2.transform.Find ("Text").GetComponent<Text>().text = "Find recruitment opportunities.";
			GUI.id.event_view.choice3.transform.Find ("Text").GetComponent<Text>().text = "Hack park security system.";
			GUI.id.event_view.choice4.transform.Find ("Text").GetComponent<Text>().text = "Obtain funds illegally.";
			break;
		case 1:
			GUI.id.event_view.location_name.text = Game.id.city.levels [2].locations [2].name;
			GUI.id.event_view.graphic.sprite = Resources.Load<Sprite> ("Images/Events/citypark_default");
			GUI.id.event_view.description.text = "There is an abundance of students in the park today.";
			GUI.id.event_view.choice1.transform.Find ("Text").GetComponent<Text>().text = "Go on rampage!";
			GUI.id.event_view.choice2.transform.Find ("Text").GetComponent<Text>().text = "Find recruitment opportunities.";
			GUI.id.event_view.choice3.transform.Find ("Text").GetComponent<Text>().text = "Hack park security system.";
			GUI.id.event_view.choice4.transform.Find ("Text").GetComponent<Text>().text = "Obtain funds illegally.";
			break;
		case 2:
			GUI.id.event_view.location_name.text = Game.id.city.levels [2].locations [2].name;
			GUI.id.event_view.graphic.sprite = Resources.Load<Sprite> ("Images/Events/citypark_default");
			GUI.id.event_view.description.text = "Today is a BBQ day, families roast synthetic meat and discuss life matters.";
			GUI.id.event_view.choice1.transform.Find ("Text").GetComponent<Text>().text = "Go on rampage!";
			GUI.id.event_view.choice2.transform.Find ("Text").GetComponent<Text>().text = "Find recruitment opportunities.";
			GUI.id.event_view.choice3.transform.Find ("Text").GetComponent<Text>().text = "Hack park security system.";
			GUI.id.event_view.choice4.transform.Find ("Text").GetComponent<Text>().text = "Obtain funds illegally.";
			break;
		case 3:
			GUI.id.event_view.location_name.text = Game.id.city.levels [2].locations [2].name;
			GUI.id.event_view.graphic.sprite = Resources.Load<Sprite> ("Images/Events/citypark_default");
			GUI.id.event_view.description.text = "An imminent personality is giving out autographs in the park today.";
			GUI.id.event_view.choice1.transform.Find ("Text").GetComponent<Text>().text = "Go on rampage!";
			GUI.id.event_view.choice2.transform.Find ("Text").GetComponent<Text>().text = "Find recruitment opportunities.";
			GUI.id.event_view.choice3.transform.Find ("Text").GetComponent<Text>().text = "Hack park security system.";
			GUI.id.event_view.choice4.transform.Find ("Text").GetComponent<Text>().text = "Obtain funds illegally.";
			break;
		}
	}

	#endregion

}
