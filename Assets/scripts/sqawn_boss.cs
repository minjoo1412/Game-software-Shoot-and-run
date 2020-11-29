using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//김민주
//boss소환 Factory
public class sqawn_boss : MonoBehaviour
{
    float minTime = 1;
    float maxTime = 5;
    float currentTime;
    float createTime = 1;
    float count_level = 1;
    public GameObject enemyFactory;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerScript.level == count_level*5){
            GameObject enemy = Instantiate(enemyFactory);
            enemy.transform.position = transform.position;
            count_level++;
        }

    }
}
