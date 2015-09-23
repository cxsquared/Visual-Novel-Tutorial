using UnityEngine;
using System.Collections;
using System.Text.RegularExpressions;

public class SceneSelectButtons : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadScene() {
		// look at button name
		string buttonName = this.name;
		// get numbers from button name
		string buttonNumber = Regex.Replace(buttonName, "[^0-9]", "");
		int levelNumber = int.Parse(buttonNumber);

		Debug.Log (levelNumber);
		// load scene + numbers
		Application.LoadLevel ("Scene" + levelNumber);
	}
}
