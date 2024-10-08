using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody rb;
    private float moveX, moveY;
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
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        moveX = movementVector.x;
        moveY = movementVector.y;
    }

    void SetCountText()
    {
        countText.text = "Count:" + count.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(DateTime.Now);
        if (other.gameObject.CompareTag("Collectible"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            //Debug.Log(count);
            SetCountText();
            if(count > 2)
            {
                winTextObject.SetActive(true);
            }
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = new Vector3 (moveX, 0, moveY);
        rb.AddForce(movement*9);
    }
}
