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
	public Animation animation;	
	PlayerScript playerScript;
	private float count = 1;
	private float leg_count = 1;
	public bool isleg = false;
	private float leg_hit = 0;

	private void Update () {
		//If the target is hit
		if (isHit == true) 
		{
			hp = hp - damage;
			isHit = false;
			if(isleg == true){
				leg_hit++;
				isleg = false;
			}
		}

		if(leg_hit >= 2 && leg_count == 1 && animator.GetCurrentAnimatorStateInfo(0).nameHash != Animator.StringToHash("Base Layer.zombie_die")){
			animator.Play("zombie_crawl");
			leg_count--;
		}

		
		if(hp < 0  && count == 1){
			count --;
			PlayerScript.exp++;
			FPSControllerLPFP.FpsControllerLPFP.kill++;
			FPSControllerLPFP.FpsControllerLPFP.skill++;
			animator.SetTrigger("dying");
			gameObject.tag = "dead_zombie";
			Destroy(enemy, 3.0f);
		}

	}

	//Time before the target pops back up
}
// ----- Low Poly FPS Pack Free Version -----