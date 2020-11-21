using UnityEngine;
using System.Collections;

// ----- Low Poly FPS Pack Free Version -----
public class PlayerScript : MonoBehaviour {

	//Used to check if the target has been hit
	public bool isHit = false;
	public float Dam;

	public static float exp = 0;
	public static float level = 1;

	private float hp = 100;
	public GameObject player;
	private void Update () {

		//If the target is hit
		if (isHit == true) 
		{
			hp = hp - Dam;
			isHit = false;
		}
		Debug.Log(hp);
		if(hp <= 0){
			Destroy(player);
		}

		level_up();
		
	}

	private void OnCollisionEnter(Collision collision){
		if(collision.collider.tag == "enemy"){
			Debug.Log("아파");
			Dam = 5;
			isHit = true;
		}
	}

	private void level_up(){
		if(exp >= 10){
			level++;
			exp = exp - 10;
			Debug.Log("level : " + level);
		}
	}

	//Time before the target pops back up
}
// ----- Low Poly FPS Pack Free Version -----