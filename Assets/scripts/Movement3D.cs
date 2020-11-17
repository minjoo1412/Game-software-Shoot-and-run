using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement3D : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;
    [SerializeField]
    private float jump = 10.0f;
    private float gravity = -9.81f;
    private Vector3 dir;
    private CharacterController characterController;
    private Vector3 moveDirection;
    [SerializeField]
    private Transform cameraTransform;
    // Start is called before the first frame update
    void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(characterController.isGrounded == false){
            dir.y += gravity * Time.deltaTime;
        }
        characterController.Move(dir*speed*Time.deltaTime);
    }
    public void MoveTo(Vector3 direction){
        Vector3 movedis = cameraTransform.rotation * direction;
        dir = new Vector3(movedis.x, dir.y, movedis.z);
    }
    public void JumpTo(){
        if(characterController.isGrounded == true){
            dir.y = jump;
        }
    }
}
