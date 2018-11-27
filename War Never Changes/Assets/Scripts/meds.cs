using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meds : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<Scores>().MEDS++;
            //add 1 to point
            Destroy(gameObject);
        }
    }
}
