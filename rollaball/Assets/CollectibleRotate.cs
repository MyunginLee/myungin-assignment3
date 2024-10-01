using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.deltaTime);
        transform.Rotate(new Vector3(15, 30, 45)* 0.001f);
        //transform.rotation = Quaternion.Euler(15, 30, 45 * DateTime.Now.Second);
    }
}
