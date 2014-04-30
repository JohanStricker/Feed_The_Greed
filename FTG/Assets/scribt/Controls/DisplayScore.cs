using UnityEngine;
using System.Collections;

public class DisplayScore : MonoBehaviour {
	//joha
	//creates the gui object and keeps it updated
	public Rect PositionOfTheText;
	string onScreenText;
	public GUIStyle Style;
	public int count = 0;
	
	void Start () {
		
	}
	void Update () {

		onScreenText = "Treasure: " + count.ToString();
	}
	void OnGUI()
	{
		//GUI.color = new Color( 255, 255, 255,0.9f);
		//GUI.color = Color.white;
		GUI.Label(PositionOfTheText, onScreenText, Style);

	}
}
