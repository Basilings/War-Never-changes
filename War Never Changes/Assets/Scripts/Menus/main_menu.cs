using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagment;


public class main_menu : MonoBehaviour {

	public void play_game()
    {
        SceneManger.loadscene(SceneManger.GetActiveScene().buildIndex + 1);
    }
}