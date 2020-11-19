using UnityEngine;
using System.Collections;

// ----- Low Poly FPS Pack Free Version -----
public class EnemyScript : MonoBehaviour {

	float randomTime;
	bool routineStarted = false;

	//Used to check if the target has been hit
	public bool isHit = false;
	public float damage;

	[Header("Customizable Options")]
	//Minimum time before the target goes back up
	public float minTime;
	//Maximum time before the target goes back up
	public float maxTime;

	[Header("Audio")]
	public AudioClip upSound;
	public AudioClip downSound;

	public AudioSource audioSource;
	private float hp = 5;
	public GameObject enemy;
	private void Update () {

		//If the target is hit
		if (isHit == true) 
		{
			hp = hp - damage;
			isHit = false;
		}
		Debug.Log(hp);
		if(hp < 0){
			Destroy(enemy);
		}
		
	}

	//Time before the target pops back up
}
// ----- Low Poly FPS Pack Free Version -----