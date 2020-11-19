using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemyhealth : MonoBehaviour
{
 
 	public bool Hit = false;
	public float Damage;
    public Animator animator;

    private float hp = 10;
    // Update is called once per frame
    public NavMeshAgent agent;
    
    private void Awake(){
        animator = GetComponent<Animator>();
    }
    private float count = 0;
   
    void Update()
    {
        
    }
}
