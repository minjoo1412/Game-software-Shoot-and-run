using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_camera : MonoBehaviour
{
    private float rotatespeedx = 3;
    private float rotatespeedy = 5;
    private float limitminx = -80;
    private float limitmaxx = 50;
    private float euleranglex;
    private float eulerangley;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RotateTo(float mouseX, float mouseY){
       eulerangley += mouseX * rotatespeedx;
       euleranglex -= mouseY * rotatespeedy;
       euleranglex = ClampAngle(euleranglex,limitminx,limitmaxx);
       transform.rotation = Quaternion.Euler(euleranglex,eulerangley,0);
    }

    private float ClampAngle(float angle, float min, float max){
        if(angle < -360)angle += 360;
        if(angle > 360) angle -= 360;
        return Mathf.Clamp(angle, min, max);
    }
}
