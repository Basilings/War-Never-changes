using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text_active : MonoBehaviour {

    public GameObject text_box;


    private void Start()
    {
        text_box.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            text_box.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            text_box.SetActive(false);
        }
    }
}
