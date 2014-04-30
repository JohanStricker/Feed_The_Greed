using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MapGenerate : MonoBehaviour {
	//johan

	//gameobjects and list for the map generation
	public GameObject Solid;
	public GameObject Hallway;
	public GameObject Turn;
	public GameObject Cross;
	public List<GameObject> Blocks = new List<GameObject>();

	//size of the grid of blocks
	public int areaY = 15;
	public int areaX = 15;
	//start location from which the grid of blocks is build
	public Vector2 location;
	//just size 1, cuz meh
	private int size = 1;
	//next three used for 
	private int blockType;
	private int HallwayType;
	private int TurnType;

	//stuck this in awake to have the map down as the first thing
	void Awake(){
		float x,y;
		location = new Vector2(0,0);
		//dual forloop for generating the blocks in a grid
		for(int j=0;j<areaY/size;j++){
			y = j*size+size/2 + location.y;
			for(int i=0;i<areaX/size;i++){
				x = i*size+size/2 + location.x;
				blockType = Random.Range (0,4);
				//if statement for making the edge always solid
				if(j!=0&&i!=0&&i!=areaX/size-1&&j!=areaY/size-1){
					//massive switch for choosing which object to place
					switch(blockType){
					case 0:
						Blocks.Add((GameObject)Instantiate(Solid, new Vector3(x, y, 0), Quaternion.identity));
						break;
					case 1:
						Blocks.Add((GameObject)Instantiate(Cross, new Vector3(x, y, 0), Quaternion.identity));
						break;
					case 2:
						HallwayType = Random.Range(0,2);
						//switch in a switch to choose rotation
						switch(HallwayType){
						case 0:
							Blocks.Add((GameObject)Instantiate(Hallway, new Vector3(x, y, 0), Quaternion.identity));
							break;
						case 1:
							Blocks.Add((GameObject)Instantiate(Hallway, new Vector3(x, y, 0), Quaternion.Euler(0,0,90)));
							break;
						}
						break;
					case 3:
						TurnType = Random.Range(0,4);
						//switch in a switch to choose rotation
						switch(TurnType){
						case 0:
							Blocks.Add((GameObject)Instantiate(Turn, new Vector3(x, y, 0), Quaternion.identity));
							break;
						case 1:						
							Blocks.Add((GameObject)Instantiate(Turn, new Vector3(x, y, 0), Quaternion.Euler(0,0,90)));
							break;
						case 2:
							Blocks.Add((GameObject)Instantiate(Turn, new Vector3(x, y, 0), Quaternion.Euler(0,0,180)));
							break;
						case 3:
							Blocks.Add((GameObject)Instantiate(Turn, new Vector3(x, y, 0), Quaternion.Euler(0,0,270)));
							break;
						}
						break;
					}
				}else{
					Blocks.Add((GameObject)Instantiate(Solid, new Vector3(x, y, 0), Quaternion.identity));
				}
			}
		}


	}
	void Start () {




	}
	

	
	// Update is called once per frame
	void Update () {
	
	}
}
