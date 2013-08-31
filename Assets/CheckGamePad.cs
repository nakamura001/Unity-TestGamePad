using UnityEngine;
using System.Collections;
using System;

public class CheckGamePad : MonoBehaviour {
	public GUISkin CustomGUISkin;
	
	private string infoText = "";

	void Start () {
	}
	
	void OnGUI () {
		GUI.skin = CustomGUISkin;
		
		infoText = "";

		for (int i=1; i<11; i++) {

			if (Mathf.Abs(Input.GetAxis("axis" + i)) > 0.01f) {
				infoText += "axis " + i + "(" + Input.GetAxis("axis" + i).ToString() + ")" + "\n";
			}
		}
		
		/*
		for (int i=0; i<20; i++) {
			if (Input.GetButton("button" + i.ToString())) {
				infoText += "button " + i + "\n";
			}
		}
		*/

		/*
		for (int i=0; i<20; i++) {
			if (Input.GetKey(KeyCode.Joystick1Button0 + i)) {
					infoText += "Joystick1Button" + i + "\n";
			}
			if (Input.GetKey(KeyCode.Joystick2Button0 + i)) {
					infoText += "Joystick2Button" + i + "\n";
			}
			if (Input.GetKey(KeyCode.Joystick3Button0 + i)) {
					infoText += "Joystick3Button" + i + "\n";
			}
			if (Input.GetKey(KeyCode.Joystick4Button0 + i)) {
					infoText += "Joystick4Button" + i + "\n";
			}
		}
		*/
		KeyCode[] KeyCodeList = (KeyCode[])Enum.GetValues(typeof(KeyCode));
		foreach(KeyCode code in KeyCodeList) {
			if (Input.GetKey(code)) {
					infoText += code.ToString() + "\n";
			}
		}

		GUI.Label(new Rect(5, 5, Screen.width * .5f, Screen.height - 10.0f), infoText);
	}
}
