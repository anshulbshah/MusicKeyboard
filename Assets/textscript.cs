using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class textscript : MonoBehaviour {
	Text tex;
	// Ushis for initialization
	void Start () {
		tex = gameObject.GetComponent<Text> ();
		tex.text = "Score : ";
	}
	void onGui()
	{gameObject.guiText.text = "Testing Script";
		}
	// Update is called once per frame
	void Update () {
		tex.text = "Score : " + play.commonscore + "  Correct Presses : " + play.correct_presses + "  Incorrect Presses : " + play.incorrect_presses;
	//	gameObject.guiText.text = "Testing Script";
	}
}
