using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountDown : MonoBehaviour {
    public float Count = 3;
    public Text text;
    // Update is called once per frame
    void Update () {
        Count -= Time.deltaTime;
        if (Count > 0) {
            text.text = Count.ToString ();
        } else {
            text.text = "Game Start!!!";
        }
    }
}