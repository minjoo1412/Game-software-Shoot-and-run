﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sqawn_healpack : MonoBehaviour
{
    float currentTime;
    float createTime = 1;
    public GameObject healFactory;
    // Start is called before the first frame update
    void Start()
    {
        createTime = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime > createTime && gameObject.tag == "heal_off"){
            GameObject heal = Instantiate(healFactory);
            heal.transform.position = transform.position;
            currentTime = 0;
            gameObject.tag = "heal_on";
            Debug.Log(gameObject.tag);
        }
        Debug.Log("spawn" + gameObject.tag);
    }
}

