using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.I)){
            animator.Play("RUN00_F");
        }else if(Input.GetKeyDown(KeyCode.R)){
            animator.Play("idle");
        }
    }
}
