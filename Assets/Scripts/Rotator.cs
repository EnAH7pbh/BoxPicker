using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
    public float timeLeft = 3;
    public bool useTime = false;
    // Update is called once per frame
    void FixedUpdate () {
        Vector3 direction = new Vector3 (Random.value, Random.value, Random.value);
        transform.Rotate (direction);
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0 && useTime == true) {
            this.transform.localScale = (new Vector3 (0, 0, 0));
        }
    }
}