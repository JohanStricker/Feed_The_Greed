using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LocateAndTurnBlock : MonoBehaviour {
	//johan
	public List<GameObject> CopiBlocks = new List<GameObject>();
	GameObject go;
	private float targetDist = 0.5f;
	private float dist;
	//public bool bob;
	//private int x,CC;


	// Use this for initialization
	void Start () {
		//next line show things above the codeline at their place
		//this.list				objectGM		mapgenerate in GM	Blocks list in mapgenerate in GM
		CopiBlocks = GameObject.Find("GM").GetComponent<MapGenerate>().Blocks;
		//CC=CopiBlocks.Count;
		//x = GameObject.Find("GM").GetComponent<MapGenerate>().areaX;
		//bob = false;


		//CopiBlocks = GameObject.Find("GM").GetComponent<GM>.Blocks;
		//totalRaceTime = GameObject.Find("RaceManager").GetComponent<RaceMa nager>.totalTime;
	}
	
	// Update is called once per frame
	void Update () {



		/*...sudden realisation.... tag mean that this is not needed.. ffs
		//the condition
		if(Input.GetKey(KeyCode.Space)){
			//the action
			//go.transform.Rotate(new Vector3(0,0,90));
			for(int I = CC-1;I>=0;I--){
				//chooses the edge in this huge shit

				if( I>((x*x)-(x+2)) || I<(x+1) ){
					go = CopiBlocks[I];
					go.tag = "Edge";

				}
				for(int k = 0;k<x;k++){
					if(I==(x+x)*(0.5f+k)||I==(x+x)*(1.0f+k)){
						go = CopiBlocks[I];
						go.tag = "Edge";

					}

					if(I==((x+x)*(0.5f+k))-1 || I==((x+x)*(1.0f+k))-1){
						go = CopiBlocks[I];
						go.tag = "Edge";
					}
				}
				
			}
		}*/
		//
		//when the key is hit it goes thorugh the list of block to find the one which location its closest to this game object
		if(Input.GetKeyUp(KeyCode.C)){
			foreach(GameObject I in CopiBlocks){
				if(I.tag == "Center"){
					dist = Vector3.Distance(I.transform.position,transform.position);
					if(dist<targetDist){
						//the action goes in here
						I.transform.Rotate(new Vector3(0,0,90));
					}
				}
			}
		}

	}

}
