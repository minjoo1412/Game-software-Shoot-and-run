using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Movement3D movement3D;
    [SerializeField]
    private KeyCode jumpkey = KeyCode.Space;
    
    
    [SerializeField]
    private Player_camera cameraController;
    // Start is called before the first frame update
    void Awake()
    {
        movement3D = GetComponent<Movement3D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        movement3D.MoveTo(new Vector3(x,0,z));

        if(Input.GetKeyDown(jumpkey)){
            movement3D.JumpTo();
        }

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        cameraController.RotateTo(mouseX, mouseY);
    }
}
