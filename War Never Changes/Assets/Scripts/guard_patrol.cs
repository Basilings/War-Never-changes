using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class guard_patrol : MonoBehaviour {

    public float max_speed = 2;
    public Transform LeftPos, RightPos;
    public float flip = 180;
    private Rigidbody _myRB;
    private bool _isFacingLeft;
    private Vector3 reset_position;
    private Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
        _myRB = GetComponent<Rigidbody>();
    }


    void Update()
    {
        //Moves the guard
        _myRB.velocity = new Vector3(max_speed * transform.localScale.x, _myRB.velocity.y, _myRB.velocity.z);

        //flips the guard
        if (transform.position.x > RightPos.position.x && !_isFacingLeft)
        {
            Flip();
        }

        if (transform.position.x < LeftPos.position.x && _isFacingLeft)
        {
            Flip();
        }


        if (transform.position.z > -0.5 || transform.position.z < 0.5)
        {
            reset_position = new Vector3(transform.position.x, transform.position.y, 0);

            transform.position = reset_position;
        }

    }

    void Flip()
    {
        //changes the scale of the guard when flipped
      
        _isFacingLeft = !_isFacingLeft;
        animator.SetTrigger("Turn");


    }


    


}
