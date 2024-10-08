using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopFor : MonoBehaviour
{
    float number1;
    float number2;
    float number3;

    float number4, number5, number6;

    float[] students;
    GameObject[] collectibles;

    // Start is called before the first frame update
    void Start()
    {
        students = new float[100];
        collectibles = new GameObject[100];
        float r = 10;
        for (int i = 0; i < 100; i++)
        {   // specify the GO, and copy GO
            collectibles[i] = GameObject.Instantiate(GameObject.Find("Collectible")) ;
            // Position?
            float x = r * Mathf.Cos(i / 15f); // 99 / 30 ~- 3.3 ~= 3.14
            float y = (r+i/10f) * Mathf.Sin(i / 15f);
            collectibles[i].transform.position = new Vector3(x, 0, y);
        }
                
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
