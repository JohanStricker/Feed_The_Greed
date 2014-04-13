using UnityEngine;
using System.Collections;

public class TorchesOnOff : MonoBehaviour {

	private int state;
	public void TurnOnTorch(){
		gameObject.light.enabled = true;
	}
	public void TurnOffTorch(){
		gameObject.light.enabled = false;
	}
	void Start () {
		state = Random.Range(0,2);
		if(state == 0){
			TurnOffTorch();
		}else{
			TurnOnTorch();
		}


	}
	
	// Update is called once per frame
	void Update () {

	}

}
