using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class healpack : MonoBehaviour
{

    public GameObject heal_point;

    private void Awake(){
        Debug.Log("hello");
        heal_point = GameObject.Find("heal_point");
    }

    private void OnCollisionEnter(Collision collision){

        if (collision.transform.tag == "Player" && PlayerScript.player_hp <= PlayerScript.max_player_hp - 10) 
		{   
            heal_point.tag = "heal_off";
            Debug.Log(heal_point.tag);
            Debug.Log("eat");
			PlayerScript.player_hp += 10;
			Destroy(gameObject);
		}


    }





}
