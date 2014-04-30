using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float moveSpeed = 1F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate(new Vector3(Input.GetAxis("Horizontal")/2 * moveSpeed * Time.deltaTime,0,0));
		transform.Translate(new Vector3(0,Input.GetAxis("Vertical")/2 * moveSpeed * Time.deltaTime,0));
		

	
	}
}
