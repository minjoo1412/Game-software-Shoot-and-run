using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sqawn_zombie : MonoBehaviour
{
    float minTime = 1;
    float maxTime = 5;
    float currentTime;
    float createTime = 1;
    public GameObject enemyFactory;
    // Start is called before the first frame update
    void Start()
    {
        createTime = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime > createTime){
            GameObject enemy = Instantiate(enemyFactory);
            enemy.transform.position = transform.position;
            createTime = Random.Range(minTime, maxTime);
            currentTime = 0;
        }
    }
}
