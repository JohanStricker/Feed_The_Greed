using UnityEngine;
using System.Collections;

public class PickUpTreasure : MonoBehaviour {
	//johan

	void Start () {

	}
	void Update () {

	}


	void OnCollisionEnter(Collision C) {
		//destroys and add one to count when a treasure is hit
		if(C.gameObject.name == "Chest(Clone)"){
			Destroy(C.gameObject);
			GameObject.Find("Score").GetComponent<DisplayScore>().count++;
		}
		
	}
	/*public Rect PositionOfTheText;
	string onScreenText;
	public GUIStyle Style;
	int counter = 0;
	
	
	void Update()
	{
		counter+=1;
		onScreenText = "Awesomeness - " + counter.ToString();
	}
	
	void OnGUI()
	{
		GUI.Label(PositionOfTheText, onScreenText, Style);
	}*/

}
