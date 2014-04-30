using UnityEngine;
using System.Collections;

public class PlayerDeath : MonoBehaviour {
	//johan
	void Start () {
		
	}
	void Update () {
		
	}
	
	
	void OnCollisionEnter(Collision C) {
		//ends the game when hitting a dragon.. aka death
		if(C.gameObject.name == "Dragon(Clone)"){
			Application.LoadLevel (2);
		}
		
	}
}
