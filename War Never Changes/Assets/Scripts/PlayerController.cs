using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float back_ground = 10;
    public Transform player;
    public float player_speed = -4;
    private CharacterController _controller;
    
    // Use this for initialization
    void Start()
    {

        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        //Movement
        
            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
            _controller.SimpleMove(move * player_speed);
        

       
        if (Input.GetKeyDown(KeyCode.W))
        {
            player.Translate(0, 0, -back_ground);

            _controller.enabled = !_controller.enabled;
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            player.Translate(0, 0, back_ground);

            _controller.enabled = !_controller.enabled;
        }


        //Changing color

        if (Input.GetKeyDown(KeyCode.R))
        { 
            
                gameObject.GetComponent<Renderer>().material.color = Color.red;

         }

        if (Input.GetKeyDown(KeyCode.B))
         {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;

         }


        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BackGround")
        {
            player_speed = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "BackGround")
        {
            player_speed = 4;
        }
    }
}
