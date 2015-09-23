using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public class DialogueParser : MonoBehaviour {

	List<DialogueLine> lines;

	struct DialogueLine {
		public string name;
		public string content;
		public int pose;

		public DialogueLine(string n, string c, int p) {
			name = n;
			content = c;
			pose = p;
		}
	}

	// Use this for initialization
	void Start () {
		string file = "Assets/Data/Dialogue";
		string sceneNum = EditorApplication.currentScene;
		sceneNum = Regex.Replace (sceneNum, "[^0-9]", "");
		file += sceneNum;
		file += ".txt";

		lines = new List<DialogueLine>();

		LoadDialogue (file);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void LoadDialogue(string filename) {
		string line;
		StreamReader r = new StreamReader (filename);

		using (r) {
			do {
				line = r.ReadLine();
				if (line != null) {
					string[] lineData = line.Split(';');
					DialogueLine lineEntry = new DialogueLine(lineData[0], lineData[1], int.Parse(lineData[2]));
					lines.Add(lineEntry);
				}
			}
			while (line != null);
			r.Close();
		}
	}

	public string GetName(int lineNumber) {
		if (lineNumber < lines.Count) {
			return lines[lineNumber].name;
		}
		return "";
	}

	public string GetContent(int lineNumber) {
		if (lineNumber < lines.Count) {
			return lines[lineNumber].content;
		}
		return "";
	}

	public int GetPose(int lineNumber) {
		if (lineNumber < lines.Count) {
			return lines[lineNumber].pose;
		}
		return 0;
	}
}
