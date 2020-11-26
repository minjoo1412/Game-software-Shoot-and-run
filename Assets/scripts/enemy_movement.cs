using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy_movement : MonoBehaviour
{
    private movement Movement;
    public GameObject gunman;
	public Animator animator;
    
    

    private void Awake(){
        Movement = GetComponent<movement>();
        gunman = GameObject.Find("Gun Camera");
        animator = gameObject.GetComponent<Animator>();
    }


    private void Update(){
        if(animator.GetCurrentAnimatorStateInfo(0).nameHash == Animator.StringToHash("Base Layer.zombie_die")){
            gunman = gameObject;
        }
        Movement.MoveTo(gunman.transform.position);

    }


}
