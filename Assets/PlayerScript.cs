﻿using UnityEngine;
using System.Collections;

// ----- Low Poly FPS Pack Free Version -----
public class PlayerScript : MonoBehaviour {

	//Used to check if the target has been hit
	public bool isHit = false;
	public float Dam;

	public static float exp = 0;
	public static float level = 1;
	public static float max_player_hp;
	public static float player_hp = 100;
	public GameObject player;

	private void Awake(){
		max_player_hp = 100;
	}
	private void Update () {

		//If the target is hit
		if (isHit == true) 
		{
			player_hp = player_hp - Dam;
			isHit = false;
		}
		if(player_hp <= 0){
			Destroy(player);
		}
		
		level_up();
		
	}

	private void OnCollisionEnter(Collision collision){
		if(collision.collider.tag == "enemy"){
			Dam = 5;
			isHit = true;
		}
	}

	private void level_up(){
		if(exp >= 10){
			level++;
			exp = exp - 10;
			Debug.Log("level : " + level);
			max_player_hp = 100 + 10*(level - 1);
			player_hp = max_player_hp;
		}
	}

	//Time before the target pops back up
}
// ----- Low Poly FPS Pack Free Version -----