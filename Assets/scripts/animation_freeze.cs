using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_freeze : MonoBehaviour
{

    private void OnAnimatorMove(){
        Animator animator = GetComponent<Animator>();
        if(animator){
            Debug.Log("hello");
            Vector3 Position = transform.position;
            Position.x += animator.GetFloat("Runspeed")*Time.deltaTime;
            transform.position = Position;
        }
    }
}
