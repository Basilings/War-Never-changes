using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class guard_patrol : MonoBehaviour {

    public float max_speed = 3;
    public Transform LeftPos, RightPos;
    public float flip = 180;
    private Rigidbody _myRB;
    private bool _isFacingLeft;
    private Vector3 reset_position;


    void Start()
    {
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
        Vector3 myScale = transform.localScale;
        myScale.x *= -1;
        transform.localScale = myScale;
        _isFacingLeft = !_isFacingLeft;

        transform.Rotate(new Vector3(180, 0, 0));

    }


    


}
