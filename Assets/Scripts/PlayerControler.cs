using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public Text countText;
    private int count;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        setCountText();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            setCountText();
        }
    }

    void setCountText()
    {
        countText.text = "Count : " + count.ToString();
        if (count >= 12)
        {
            countText.text = "You Win!";
        }
    }
}
