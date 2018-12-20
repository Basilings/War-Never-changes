using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class detect_player : MonoBehaviour
{


    // if the player isn't distguised then the start scene will load
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && other.GetComponent<PlayerController>().distguised == false)
        {
            SceneManager.LoadScene("Fail Scene");
        }
    }
}
