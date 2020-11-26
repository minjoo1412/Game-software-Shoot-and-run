using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mutant_movement : MonoBehaviour
{
    private movement Movement;
    public GameObject gunman;
	public Animator animator;
    
	public static bool attack_now = false;

    private void Awake(){
        Movement = GetComponent<movement>();
        gunman = GameObject.Find("Gun Camera");
    }

    private void Update(){
        if(animator.GetCurrentAnimatorStateInfo(0).nameHash == Animator.StringToHash("Base Layer.dying")){
            gunman = gameObject;
        }
        Movement.MoveTo(gunman.transform.position);

        if(attack_now){
            animator.SetTrigger("attack");
            attack_now = false;
        }
    }
}
