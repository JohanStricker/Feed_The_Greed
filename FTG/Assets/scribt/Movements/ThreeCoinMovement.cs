using UnityEngine;
using System.Collections;

public class ThreeCoinMovement : MonoBehaviour {
	//johan
	public GameObject target;

	private Vector3 Dir;
	private Vector3 velo = new Vector3(0,0,0);
	
	// Use this for initialization
	void Start () {
		target = GameObject.Find("Hover_Player(Clone)");
	}
	
	// Update is called once per frame
	void Update () {
		Movement();


	}
	void Movement(){
		//movement created by using the basic concepts of vector math.. makes a smooth and nice movement
		Dir = target.transform.position-transform.position;
		Dir.Normalize();
		Dir*=0.15f;
		velo += Dir;
		if(velo.magnitude>0.8f){
			velo = velo.normalized*0.8f;
		}
		transform.position += velo*Time.deltaTime;	
	}

}
