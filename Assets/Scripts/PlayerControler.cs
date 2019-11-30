using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerControler : MonoBehaviour {
    public float speed;
    private Rigidbody rb;
    public Text countText;
    private int count;
    public GameObject finish;
    public string scene = "scene";
    public bool useTime = false;
    public float timeLeft = 3;
    private void Start () {
        rb = GetComponent<Rigidbody> ();
        count = 0;
        setCountText ();
    }

    private void FixedUpdate () {
        timeLeft -= Time.deltaTime;
        if (timeLeft > 0 && useTime == true) {

        } else {
            float moveHorizontal = Input.GetAxis ("Horizontal");
            float moveVertical = Input.GetAxis ("Vertical");
            Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
            rb.AddForce (movement * speed);
        }

    }

    private void OnTriggerEnter (Collider other) {
        if (other.gameObject.CompareTag ("Pick Up")) {
            other.gameObject.SetActive (false);
            count = count + 1;
            setCountText ();
        }
        if (other.gameObject.CompareTag ("Finish")) {
            SceneManager.LoadScene (scene);
        }
    }

    void setCountText () {
        countText.text = "Count : " + count.ToString ();
        if (count >= 12) {
            countText.text = "Collect the Green object";
            finish.SetActive (true);
        }
    }
}