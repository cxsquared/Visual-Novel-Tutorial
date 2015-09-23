using UnityEngine;
using System.Collections;

public class SceneSelectMenuButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadSceneSelect() {
		Application.LoadLevel (1);
	}
}
