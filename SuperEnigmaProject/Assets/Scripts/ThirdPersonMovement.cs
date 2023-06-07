using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ThirdPersonMovement : MonoBehaviour
{   public CharacterController controller;
    public float speed = 6f;
    InputMaster controls;
    void Awake(){
        controls = new InputMaster();

        controls.Player.Movement.performed += ctx => Move(ctx.ReadValue<Vector2>());
        controls.Player.Jump.performed += _ => Jump();
    }

    void Jump()
    {
        //GET PLAYER TO JUMP
        Debug.Log("Player wants to JUMP...");
    }

    void OnEnable(){
        controls.Enable();
    }

    void OnDisable(){
        controls.Disable();
    }

    void Move(Vector2 dir){
        //MOVE THE PLAYER
        Debug.Log("Player wants to MOVE TO : " + dir);
    }
}
