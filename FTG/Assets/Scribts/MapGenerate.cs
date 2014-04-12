using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MapGenerate : MonoBehaviour {

	// Use this for initialization
	public GameObject Solid;
	public GameObject Hallway;
	public GameObject Turn;
	public GameObject Hall;
	public GameObject Cross;
	public List<GameObject> Blocks = new List<GameObject>();

	public int areaY = 5;
	public int areaX = 5;
	private int size = 1;

	private int blockType;
	private int HallwayType;
	private int TurnType;

	public Vector2 location;
	void Start () {

		/*int worldsize = inputWS;
		int areasize = inputAS; 
		int size = inputS;
		float x,y;
		PVector Cornerlocation = new PVector(random(areasize,worldsize)-areasize,random(areasize,worldsize)-areasize);
		for(int j=0;j<areasize/size;j++){
			
			y = j*size+size/2 + Cornerlocation.y;
			for(int i=0;i<areasize/size;i++){
				x = i*size+size/2 + Cornerlocation.x;
				Wires.add(new WireBox(new PVector(x,y),size,(int)random(3),(int)random(4)));
			}
		}*/

		float x,y;
		location = new Vector2(Random.Range(areaY,areaX)-areaY,Random.Range(areaY,areaX)-areaY);
		for(int j=0;j<areaY/size;j++){
			y = j*size+size/2 + location.y;
			for(int i=0;i<areaX/size;i++){
				x = i*size+size/2 + location.x;
				blockType = Random.Range (0,5);

				switch(blockType){
				case 0:
					Blocks.Add((GameObject)Instantiate(Solid, new Vector3(x, y, 0), Quaternion.identity));
					break;
				case 1:
					Blocks.Add((GameObject)Instantiate(Hall, new Vector3(x, y, 0), Quaternion.identity));
					break;
				case 2:
					Blocks.Add((GameObject)Instantiate(Cross, new Vector3(x, y, 0), Quaternion.identity));
					break;
				case 3:
					HallwayType = Random.Range(0,2);
					switch(HallwayType){
					case 0:
						Blocks.Add((GameObject)Instantiate(Hallway, new Vector3(x, y, 0), Quaternion.identity));
						break;
					case 1:
						Blocks.Add((GameObject)Instantiate(Hallway, new Vector3(x, y, 0), Quaternion.Euler(0,0,90)));
						break;
					}
					break;
				case 4:
					TurnType = Random.Range(0,4);
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
			}
		}
	}
	

	
	// Update is called once per frame
	void Update () {
	
	}
}
