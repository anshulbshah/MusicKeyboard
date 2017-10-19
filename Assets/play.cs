using UnityEngine;
using System.Collections;
using System.IO;

public class play : MonoBehaviour {
	public static int keyplayno;
	float starttime;
	int incs=0;
	public float increment_time;
	public static int commonscore=0;
	public static int correct_presses = 0;
	public static int incorrect_presses = 0;
	// Use this for initialization
	void Start () {
		starttime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
	if(Time.time - starttime > increment_time && incs == 0)
	{
			keyplayno = 0;
				incs++;
	}
	if(Time.time - starttime > 2*increment_time && incs ==1 )
	{
			keyplayno = 1;
			incs++;
	}
	if(Time.time - starttime > 3*increment_time && incs == 2)
		{
			keyplayno = 2;
			incs++;
		}
	if(Time.time - starttime > 4*increment_time && incs ==3 )
		{
			keyplayno = 3;
			incs++;
		}
	if(Time.time - starttime > 5*increment_time && incs == 4)
		{
			keyplayno = 2;
			incs++;
		}
	if (Time.time - starttime > 6 * increment_time && incs == 5) {
						keyplayno = 1;
						incs++;
				} else if (incs == 6) {
						System.IO.File.AppendAllText ("trial.txt","\r\n"+ "Score is :" + commonscore.ToString () + "\r\n" + "Correct Presses : " + correct_presses.ToString() + "\r\n" + "Incorrect Presses : " + incorrect_presses.ToString() + "\r\n");
						incs++;
				}
		Debug.Log (commonscore);
	}
}
