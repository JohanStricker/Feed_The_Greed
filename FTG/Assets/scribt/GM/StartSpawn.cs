using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StartSpawn : MonoBehaviour {
	//johan

	//the main spawner

	//main cam
	public GameObject MainCam;
	//gameobjectsfor the player generation
	//player and all that belongs 
	public GameObject Player;
	public GameObject ThreeCoins;
	public GameObject Hover_Player;
	public GameObject Hover_ThreeCoins;
	//gameobject and list for the Treasure generation
	public GameObject Treasure;
	public int TreasureCount = 10;
	private int TreasureLocation;
	public List<GameObject> Treasures = new List<GameObject>();
	//gameobject and list for the Dragon generation
	public GameObject Dragon;
	public int DragonCount = 10;
	private int DragonLocation;
	public List<GameObject> Dragons = new List<GameObject>();

	//
	GameObject[] PossibleSpawnPlaces;
	private int ChosenOne;
	// Use this for initialization
	void Start () {


		//choose random number from list
		PossibleSpawnPlaces = GameObject.FindGameObjectsWithTag("Center");
		ChosenOne = Random.Range(0,PossibleSpawnPlaces.Length);

		Instantiate(Player,new Vector3(PossibleSpawnPlaces[ChosenOne].transform.position.x,PossibleSpawnPlaces[ChosenOne].transform.position.y,0),Quaternion.identity);
		//spawns the main cam
		Instantiate(MainCam,new Vector3(0,0,3)*-1,Quaternion.identity);
		Instantiate(Hover_Player,new Vector3(0,0,1)*-1,Quaternion.identity);
		Instantiate(ThreeCoins,new Vector3(PossibleSpawnPlaces[ChosenOne].transform.position.x,PossibleSpawnPlaces[ChosenOne].transform.position.y,0),Quaternion.identity);
		Instantiate(Hover_ThreeCoins,new Vector3(0,0,0),Quaternion.identity);
		//all the treasures
		for(int i = 0; i <TreasureCount;i++){
			TreasureLocation = Random.Range(0,PossibleSpawnPlaces.Length);
			Instantiate(Treasure,new Vector3(PossibleSpawnPlaces[TreasureLocation].transform.position.x,PossibleSpawnPlaces[TreasureLocation].transform.position.y,0),Quaternion.Euler(-80,-10,0));


		}
		//all the dragons
		for(int i = 0; i <DragonCount;i++){
			DragonLocation = Random.Range(0,PossibleSpawnPlaces.Length);
			Instantiate(Dragon,new Vector3(PossibleSpawnPlaces[DragonLocation].transform.position.x,PossibleSpawnPlaces[DragonLocation].transform.position.y,0-0.15f),Quaternion.identity);
		}
	
	
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//recusive chooser

}
