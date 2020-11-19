﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_movement : MonoBehaviour
{
    private movement Movement;
    public GameObject gunman;

    private void Awake(){
        Movement = GetComponent<movement>();
        gunman = GameObject.Find("Gun Camera");
    }

    private void Update(){

        Movement.MoveTo(gunman.transform.position);
    }
}
