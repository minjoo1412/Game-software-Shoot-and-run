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
	public GameObject another1;
	public GameObject another2;
	public GameObject another3;
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

		if(gameObject.tag == "attack_now"){
            animator.Play("zombie_attack");
			gameObject.tag = "enemy";
        }
		if(gameObject.tag == "attack_now1"){
            animator.Play("zombie_attack");
			gameObject.tag = "enemy_leg";
        }
		
		if(hp < 0  && count == 1){
			count --;
			PlayerScript.exp++;
			FPSControllerLPFP.FpsControllerLPFP.kill++;
			FPSControllerLPFP.FpsControllerLPFP.skill++;
			animator.SetTrigger("dying");
			gameObject.tag = "dead_zombie";
			another1.tag = "dead_zombie";
			another2.tag = "dead_zombie";
			another3.tag = "dead_zombie";
			Destroy(enemy, 3.0f);
		}

	}


	//Time before the target pops back up
}
// ----- Low Poly FPS Pack Free Version -----