using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//김민주
//enemy(ch15)와 boss(ch35)의 이통을 맡는다. 설정된 목적지로 이동한다.
public class movement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5.0f;
    public float animespeed = 1f;
    private NavMeshAgent navMeshAgent;

    private void Awake(){
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    public void MoveTo(Vector3 goalPosition){
        StopCoroutine("OnMove");
        navMeshAgent.speed = moveSpeed;
        navMeshAgent.SetDestination(goalPosition);
        StartCoroutine("OnMove");
    }

    IEnumerator OnMove(){
        while(true){
            if(Vector3.Distance(navMeshAgent.destination, transform.position) < 0.1f){
                transform.position = navMeshAgent.destination;
                navMeshAgent.ResetPath();
                break;
            }
            yield return null;
        }
    }






}
