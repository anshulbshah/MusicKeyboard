using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	float time1;
	float angle = 0f;
	int k = 2;
	public KeyCode a; 
	public float factor = 5f;
	public int keyno;

	void keyispressed_inc()
	{
		if (angle > -10.0f && k == 1) {
						transform.RotateAround (new Vector3 (0f, 0f, 0f), new Vector3 (1f, 0f, 0f), -1);
						angle = angle - 1f;
				}
		//Debug.Log (angle);
		//transform.RotateAround(
	}
	void keyispressed_dec()
	{
		if (angle < 0.0f && k == 0) {
						transform.RotateAround (new Vector3 (0f, 0f, 0f), new Vector3 (1f, 0f, 0f), 1);
						angle = angle + 1f;
				}
	}
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		keyispressed_inc ();
		keyispressed_dec();
	if (keyno == play.keyplayno) {
						renderer.material.color = Color.blue;	
				} else
						renderer.material.color = Color.black;
	if (Input.GetKeyDown(a))
	{
			k =1;
			Debug.Log ("A is pressed");
			//transform.localScale = new Vector3(5,5,5);	
			time1 = Time.time;
			Debug.Log ("Print");
			audio.Play ();
			if(keyno == play.keyplayno)
			{
				play.commonscore++;
				play.correct_presses++;
			}
			else
			{	play.commonscore--;
			play.incorrect_presses++;
			}
	}
	//Debug.Log (Time.deltaTime);
	if (Input.GetKeyUp (a)) 
	{
			//transform.localScale = new Vector3 (1, 1, 1);	
			Debug.Log ("Print_releasw");

			k=0;
	}

	}
}
