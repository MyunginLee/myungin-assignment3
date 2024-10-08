using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject user;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        user = GameObject.Find("Player");
        offset = transform.position - user.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = offset + user.transform.position;        
    }
}
