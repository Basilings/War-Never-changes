using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float back_ground = 10;
    public Transform player;
    private Animator PlayerAnimator;
    private Vector3 reset_player;
    public bool distguised = false;
    private float forward;




    void Start()
    {
        PlayerAnimator = GetComponent<Animator>();
       
    }


    void Update()
    {
        PlayerAnimator.SetFloat("Forward", forward);
        forward = Input.GetAxis("Horizontal");
        //Movement
        Vector3 move = new Vector3(forward, 0, 0);


        //the sneak mechanic
        if (Input.GetKeyDown(KeyCode.W))
        {
            PlayerAnimator.SetBool("Hiding", true);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            PlayerAnimator.SetBool("Hiding", false);
            reset_player = new Vector3(player.position.x, player.position.y, 0);
            player.position = reset_player;
        }


       
        //Changing color & distguised

        if (Input.GetKeyDown(KeyCode.E))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
            distguised = true;

            
         }

        if (Input.GetKeyDown(KeyCode.E) && distguised == true)
        {

            gameObject.GetComponent<Renderer>().material.color = Color.green;

            //distguised = false;


        }




    }

}
