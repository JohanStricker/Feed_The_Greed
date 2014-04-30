using UnityEngine;
using System.Collections;

public class enemybehaviour : MonoBehaviour {
	//the tested speed variables
	public float speed = 100;
	public float rotatespeed = 50;

	//----------------------
	//unused variables
	//bool foundHitFront;
	//bool foundHitLeft;
	//bool foundHitRight;
	//bool foundHitBack;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//sets up the output for the rays
		RaycastHit frontlefthit = new RaycastHit();
		RaycastHit frontrighthit = new RaycastHit();

		//positions rays the rays on the object
		Ray frontleftray = new Ray (transform.position+new Vector3(0,0.1f,0), transform.right * -1);
		Ray frontrightray = new Ray (transform.position+new Vector3(0,0.1f,0), transform.right);
		//actually casts the rays as well as gives the output for later use
		Physics.Raycast (frontleftray, out frontlefthit);
		Physics.Raycast (frontrightray, out frontrighthit);

		//moves forward
		transform.Translate (new Vector3 (0,speed / 5 * Time.deltaTime, 0));

		//if distance to the left is bigger than the right - move left
		if (frontlefthit.distance > frontrighthit.distance) {
				transform.Rotate (Vector3.forward, 3 * rotatespeed * Time.smoothDeltaTime);
		}
		//if distance to the right is bigger than the left - move right
		if (frontlefthit.distance < frontrighthit.distance) {
				transform.Rotate (Vector3.forward, -3 * rotatespeed * Time.smoothDeltaTime);
		}

		//---------------------------------------------------------------------------------
		//unused code:
		//tried solutions of having spherecasting for moving untill something is in front and then turning
		//tried measuring distances with four raycasts on corners of the moving object

		//RaycastHit backrighthit = new RaycastHit();
		//RaycastHit backhit = new RaycastHit();
		//foundHitFront = false;
		//foundHitLeft = false;
		//foundHitRight = false;
		//foundHitBack = false;
		//RaycastHit fronthit = new RaycastHit();
		//RaycastHit backlefthit = new RaycastHit();

		//foundHitFront=Physics.SphereCast(transform.position, 0.2f, transform.up, out fronthit, 0.1f);
		//Ray backleftray = new Ray (transform.position+new Vector3(0,-0.1f,0), transform.right * -1);
		//Ray backrightray = new Ray (transform.position+new Vector3(0,-0.1f,0), transform.right);
		//Physics.Raycast (backleftray, out backlefthit);
		//Physics.Raycast (backrightray, out backrighthit);
		//foundHitLeft=Physics.SphereCast(transform.position, 0.2f, transform.right*-1, out lefthit);
		//foundHitRight=Physics.SphereCast(transform.position, 0.2f, transform.right, out righthit);
		//foundHitBack=Physics.SphereCast(transform.position, 0.2f, transform.up*-1, out backhit, 0.05f);


		//if (foundHitFront == false) {
		//}
		//if ((foundHitFront == true)) {
		/*transform.Rotate (Vector3.forward, 90 * rotatespeed * Time.smoothDeltaTime);*/
		//} 

		/*if (frontlefthit.distance == frontrighthit.distance && foundHitFront==false||frontlefthit.distance == frontrighthit.distance && foundHitFront==true) {
			transform.Rotate (Vector3.forward, 45 * rotatespeed*10 * Time.smoothDeltaTime);
		}*/
		/*if (frontlefthit.distance>backlefthit.distance){
			transform.Rotate (Vector3.forward, 15 * Time.smoothDeltaTime);
		}*/
		/*if ((frontlefthit.distance+backlefthit.distance) > (frontrighthit.distance+backrighthit.distance) ){
			transform.Rotate (Vector3.forward, 25 * Time.smoothDeltaTime);
		}*/
		/*if (frontrighthit.distance>backrighthit.distance){
			transform.Rotate (Vector3.forward, -15 * Time.smoothDeltaTime);
		}*/
		/*if ((frontlefthit.distance+backlefthit.distance) < (frontrighthit.distance+backrighthit.distance)) {
			transform.Rotate (Vector3.forward, -25 * Time.smoothDeltaTime);
				}*/
		/*if (((foundHitFront == false) && frontlefthit.distance == frontrighthit.distance)||(frontlefthit.distance == frontrighthit.distance)){
			transform.Rotate (Vector3.forward, 60 * Time.smoothDeltaTime);
		}*/


		/*if (foundHitFront == true||foundHitLeft == true&&foundHitFront == true) {
			//transform.Translate (new Vector3 (speed / 10 * Time.deltaTime, 0, 0));
			transform.Rotate (Vector3.forward, 45 * rotatespeed * Time.smoothDeltaTime);
		}
		if (foundHitRight == true) {
			transform.Rotate (Vector3.forward, -45 * rotatespeed * Time.smoothDeltaTime);
		}*/
	

		/*if (foundHitFront == false && foundHitLeft == true && foundHitRight == true && foundHitBack == true
		    ||foundHitFront == false && foundHitLeft == false && foundHitRight == true && foundHitBack == true
		    ||foundHitFront == false && foundHitLeft == true && foundHitRight == false && foundHitBack == true
		    ||foundHitFront == false && foundHitLeft == false && foundHitRight == false && foundHitBack == true) {
						transform.Translate (new Vector3 (0,speed / 10 * Time.deltaTime, 0));
				}
		if (foundHitFront == true && foundHitLeft == false && foundHitRight == true && foundHitBack == true
		         ||foundHitFront == false && foundHitLeft == false && foundHitRight == true && foundHitBack == true
		         ||foundHitFront == true && foundHitLeft == false && foundHitRight == true && foundHitBack == false
		         ||foundHitFront == false && foundHitLeft == false && foundHitRight == true && foundHitBack == false) {
			transform.Translate (new Vector3 (-(speed / 10 * Time.deltaTime),0, 0));
		}
		if (foundHitFront == true && foundHitLeft == true && foundHitRight == false && foundHitBack == true
		         ||foundHitFront == false && foundHitLeft == true && foundHitRight == false && foundHitBack == false
		         ||foundHitFront == false && foundHitLeft == true && foundHitRight == false && foundHitBack == true
		         ||foundHitFront == true && foundHitLeft == true && foundHitRight == false && foundHitBack == false) {
			transform.Translate (new Vector3 (speed / 10 * Time.deltaTime,0, 0));
		}
		if (foundHitFront == true && foundHitLeft == true && foundHitRight == true && foundHitBack == false
		        ||foundHitFront == true && foundHitLeft == false && foundHitRight == false && foundHitBack == false
		         ||foundHitFront == true && foundHitLeft == false && foundHitRight == true && foundHitBack == false
		         ||foundHitFront == true && foundHitLeft == true && foundHitRight == false && foundHitBack == false) {
			transform.Translate (new Vector3 (0,-(speed / 10 * Time.deltaTime), 0));
		}*/
		/*if (foundHitFront == false && foundHitLeft == true && foundHitRight == true && foundHitBack == true) {
						transform.Translate (new Vector3 (0, speed / 10 * Time.deltaTime, 0));
				} else if (foundHitFront == true && foundHitLeft == false && foundHitRight == true && foundHitBack == true) {
						transform.Translate (new Vector3 (-(speed / 10 * Time.deltaTime), 0, 0));
				} else if (foundHitFront == true && foundHitLeft == true && foundHitRight == false && foundHitBack == true) {
						transform.Translate (new Vector3 (speed / 10 * Time.deltaTime, 0, 0));
				} else if (foundHitFront == true && foundHitLeft == true && foundHitRight == true && foundHitBack == false) {
						transform.Translate (new Vector3 (0, -(speed / 10 * Time.deltaTime), 0));
				} */

		//if (foundHit){
						//if(!Physics.Raycast (transform.position, new Vector3(0,1,0), 1f)){
						//transform.Translate(Vector3.forward * speed * Time.deltaTime);
						//transform.Translate(new Vector3(speed/10*Time.deltaTime,0,0));
						//transform.Rotate (Vector3.forward, 90 * rotatespeed * Time.smoothDeltaTime);

						//transform.Rotate(new Vector3(0,0,90),Space.Self);
						//}
						//else if (!Physics.Raycast (transform.position, new Vector3(0,-1,0), 1f)) {

						//transform.Translate(Vector3.forward * speed * Time.deltaTime);
						//transform.Translate(new Vector3(speed/10*Time.deltaTime,0,0));
		
						//transform.Rotate (Vector3.forward, -45 * rotatespeed * Time.smoothDeltaTime);
						//transform.Rotate(new Vector3(0,0,90),Space.Self);
				//} 
		//else  if(!Physics.Raycast (transform.position, new Vector3 (1, 0, 0), 0.5f)) 
		//{
						//transform.RotateAround (new Vector3 (1, 0, 0), new Vector3 (1, 0, 0), 10);
				//}

	
	}
			//}
}
