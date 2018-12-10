using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class detect_player : MonoBehaviour
{



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && other.GetComponent<PlayerController>().distguised == false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);



        }
    }
}
