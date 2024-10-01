using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public float speed = 5;
    private int count = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();
        SetCountText();
        winTextObject.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log(DateTime.Now);
        if (other.gameObject.CompareTag("Respawn"))
        {
            other.gameObject.SetActive(false);
            // Calculation
            //count++;
            count = count + 1;
            Debug.Log(count);
            SetCountText();
        }
    }
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString(); // now string.
        //if(count > 3)
        if(count >= 4)
        {
            winTextObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Vector3 Movement = new Vector3(movementX, 0f, movementY);
        rb.AddForce(Movement * speed);
    }
}
