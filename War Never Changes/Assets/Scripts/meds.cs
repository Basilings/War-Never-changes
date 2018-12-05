using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meds : MonoBehaviour {

    int value = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<GameManager>().add_meds(value);

            Destroy(gameObject);

        }
    }
}
