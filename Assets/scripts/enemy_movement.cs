using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//김민주
//enemy(ch15)의 목적지를 설정하는 스크립트,
//살아있을때는 플레이어를 쫓지만 죽으면 멈추게 한다.
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
