using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ThirdPersonMovement : MonoBehaviour
{   public CharacterController controller;
    public float speed = 6f;
    bool cancelled;
    Vector2 move;
    InputMaster controls;
    void Awake(){
        controls = new InputMaster();

        controls.Player.Movement.performed += ctx => {move = ctx.ReadValue<Vector2>();};//Move(ctx.ReadValue<Vector2>());
        controls.Player.Movement.canceled += _ => {move = Vector2.zero;};
        controls.Player.Jump.performed += _ => Jump();
    }

    void Update(){
        Vector3 direction = new Vector3(move.x, 0, move.y).normalized; //MEANS CANT MOVE FASTER WHEN DIAGONAL

        if (direction.magnitude >= 0.1){
            Debug.Log("MOve player to " + direction);
            controller.Move(direction * speed * Time.deltaTime);
        }
    }

    void Jump()
    {
        //GET PLAYER TO JUMP
        Debug.Log("Player wants to JUMP...");
    }

    void OnEnable() => controls.Enable();

    void OnDisable() => controls.Disable();
}
