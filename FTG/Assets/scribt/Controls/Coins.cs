using UnityEngine;
using System.Collections;

public class Coins : MonoBehaviour {
	//johan
	private GameObject target;
	private bool atdude;
	private int direction;
	// Use this for initialization
	void Start () {
		target = GameObject.Find("Player(Clone)");
		atdude = true;
	}

	// Update is called once per frame
	void Update () {

		//sending the coins back at the player when he moves
		if(Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow)){
			direction = 0;
			atdude = true;
		}
		if(Input.GetKeyDown(KeyCode.S)||Input.GetKeyDown(KeyCode.DownArrow)){
			direction = 1;
			atdude = true;
		}
		if(Input.GetKeyDown(KeyCode.D)||Input.GetKeyDown(KeyCode.RightArrow)){
			direction = 2;
			atdude = true;
		}
		if(Input.GetKeyDown(KeyCode.A)||Input.GetKeyDown(KeyCode.LeftArrow)){
			direction = 3;
			atdude = true;
		}
		
		//send back
		if(atdude==true){
			transform.position = new Vector3(target.transform.position.x,target.transform.position.y,transform.position.z);
		}
		//sends the coins out when X is hit
		if(Input.GetKeyUp(KeyCode.X)){

			switch(direction){
			case 0:
				transform.position = new Vector3(transform.position.x,transform.position.y+7,transform.position.z);
				atdude = false;
				break;
			case 1:
				transform.position = new Vector3(transform.position.x,transform.position.y-7,transform.position.z);
				atdude = false;
				break;
			case 2:
				transform.position = new Vector3(transform.position.x+7,transform.position.y,transform.position.z);
				atdude = false;
				break;
			case 3:
				transform.position = new Vector3(transform.position.x-7,transform.position.y,transform.position.z);
				atdude = false;
				break;
			}

		}
	}
}
