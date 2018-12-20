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
    
    void Start()
    {
        PlayerAnimator = GetComponent<Animator>();
    }

    
    void Update()
    {

        //Movement

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
  
        

       
        //the sneak mechanic
        if (Input.GetKeyDown(KeyCode.W))
        {
            player.Translate(0, 0, -back_ground);

        }

        if (Input.GetKeyUp(KeyCode.W))
        {
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
