using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class guard_patrol : MonoBehaviour {

    public float max_speed;
    public Transform LeftPos, RightPos;
    public float flip = 180;
    private Rigidbody _myRB;
    private bool _isFacingLeft;

    void Start()
    {
        _myRB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _myRB.velocity = new Vector3(max_speed * transform.localScale.x, _myRB.velocity.y, _myRB.velocity.z);

        if (transform.position.x > RightPos.position.x && !_isFacingLeft)
        {
            Flip();
        }

        if (transform.position.x < LeftPos.position.x && _isFacingLeft)
        {
            Flip();
        }


    }

    void Flip()
    {
        Vector3 myScale = transform.localScale;
        myScale.x *= -1;
        transform.localScale = myScale;
        _isFacingLeft = !_isFacingLeft;

        transform.Rotate(new Vector3(180, 0, 0));

    }


    


}
