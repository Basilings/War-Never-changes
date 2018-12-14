using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public int current_meds;
    public Text meds_text;

    public void add_meds(int meds_add)
    {
        current_meds += meds_add;

        meds_text.text = "      : " + current_meds;
    }
}
