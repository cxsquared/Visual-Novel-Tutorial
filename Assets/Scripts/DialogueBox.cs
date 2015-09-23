using UnityEngine;
using System.Collections;

public class DialogueBox : MonoBehaviour {

	DialogueParser parser;

	public string dialogue;
	int lineNum;

	public GUIStyle customStyle;

	// Use this for initialization
	void Start () {
		dialogue = "";
		parser = GameObject.Find("DialogueParser").GetComponent<DialogueParser>();
		lineNum = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			dialogue = parser.GetContent(lineNum);
			lineNum++;
		}
	}

	void OnGUI() {
		dialogue = GUI.TextField (new Rect (100, 400, 600, 200), dialogue, customStyle);
	}
}
