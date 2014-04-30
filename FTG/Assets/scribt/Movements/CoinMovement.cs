using UnityEngine;
using System.Collections;

public class CoinMovement : MonoBehaviour {
	//johan
	private GameObject target;
	private Vector3 Dir;
	private Vector3 velo = new Vector3(0,0,0);

	// Use this for initialization
	void Start () {
		target = GameObject.Find("ThreeCoins(Clone)");
	}
	
	// Update is called once per frame
	void Update () {
		Movement();
	}
	void Movement(){
		//movement created by using the basic concepts of vector math.. makes a smooth and nice movement
		Dir = target.transform.position-transform.position;

		Dir.Normalize();
		Dir*=0.11f;

		velo += Dir;
		if(velo.magnitude>1.1f){
			velo = velo.normalized*1.1f;
		}
		transform.position += velo*Time.deltaTime;


	}
}
