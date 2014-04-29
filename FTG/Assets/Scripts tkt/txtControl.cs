using UnityEngine;
using System.Collections;

public class txtControl : MonoBehaviour {

	void  OnMouseOver (){
		
		//Change the color of the text when hovering with mouse
		renderer.material.color = Color.red;
	
	}

	void  OnMouseExit (){
		
		//Change the color of the text when NOT hovering with mouse
		renderer.material.color = Color.white;
	
	}



}




