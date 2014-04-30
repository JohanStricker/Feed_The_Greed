using UnityEngine;
using System.Collections;

public class F_Player : MonoBehaviour {
	//johan
	private GameObject target;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//follows the player

		target = GameObject.Find("Player(Clone)");
		transform.position = new Vector3(target.transform.position.x,target.transform.position.y,transform.position.z);

	}
}
