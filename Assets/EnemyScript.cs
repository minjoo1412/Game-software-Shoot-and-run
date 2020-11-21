using UnityEngine;
using UnityEngine.AI;
using System.Collections;

// ----- Low Poly FPS Pack Free Version -----
public class EnemyScript : MonoBehaviour {


	//Used to check if the target has been hit
	public bool isHit = false;
	public float damage;
	public float hp = 5;
    public GameObject enemy;
	public Animator animator;
	PlayerScript playerScript;
	private float count = 1;

	private void Update () {

		//If the target is hit
		if (isHit == true) 
		{
			PlayerScript.exp++;
			hp = hp - damage;
			isHit = false;
		}

		if(hp < 0  && count == 1){
			animator.Play("zombie_die");
			gameObject.tag = "dead_zombie";
			Debug.Log(gameObject.tag);
			Destroy(enemy, 3.0f);
			count --;
		}

	}

	//Time before the target pops back up
}
// ----- Low Poly FPS Pack Free Version -----