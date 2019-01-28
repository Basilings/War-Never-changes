using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float back_ground = 10;
    public Transform player;
    public float player_speed = 4;
    private Animator PlayerAnimator;
    private CharacterController controller;
    private Vector3 reset_player;
    public bool distguised;

    void Start()
    {

        controller = GetComponent<CharacterController>();
        PlayerAnimator = GetComponent<Animator>();


    }


    void Update()
    {

        //Movement
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        controller.SimpleMove(move * player_speed);
        move = (transform.forward);



       



        //the sneak mechanic
        if (Input.GetKeyDown(KeyCode.W))
        {
            controller.enabled = !controller.enabled;
            player.Translate(0, 0, -back_ground);
            PlayerAnimator.SetBool("Hiding", true);
        }
        

        if (Input.GetKeyUp(KeyCode.W))
        {
            controller.enabled = !controller.enabled;
            PlayerAnimator.SetBool("Hiding", false);
            reset_player = new Vector3(player.position.x, player.position.y, 0);
            player.position = reset_player;
        }



        PlayerAnimator.SetFloat("forward", (Mathf.Abs(Input.GetAxis("Horizontal"))));



        if (Input.GetKeyDown(KeyCode.E))
        {

            distguised = true;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            distguised = false;
        }


    }


   
}
