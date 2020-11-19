using UnityEngine;
using System.Collections;

// ----- Low Poly FPS Pack Free Version -----
public class PlayerScript : MonoBehaviour {

	//Used to check if the target has been hit
	public bool isHit = false;
	public float damage;

	private float hp = 100;
	public GameObject player;
	private void Update () {

		//If the target is hit
		if (isHit == true) 
		{
			hp = hp - damage;
			isHit = false;
		}
		Debug.Log(hp);
		if(hp <= 0){
			Destroy(player);
		}
		
	}

	private void OnCollisionEnter(Collision collision){
		if(collision.collider.tag == "enemy"){
			Debug.Log("아파");
			damage = 5;
			isHit = true;
		}
	}

	//Time before the target pops back up
}
// ----- Low Poly FPS Pack Free Version -----