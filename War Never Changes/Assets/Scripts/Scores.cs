using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scores : MonoBehaviour
{
    public int MEDS = 0;



    private void OnGUI()
    {
        GUI.Label(new Rect(60, 20, 200, 20), "Meds: " + MEDS);
    }

}

