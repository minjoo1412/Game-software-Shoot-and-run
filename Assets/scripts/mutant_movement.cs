using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//김민주
//boss(ch35)의 목적지를 설정하는 스크립트,
//살아있을때는 플레이어를 쫓지만 죽으면 멈추게 한다.
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
