using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ForLoop : MonoBehaviour
{
    float number1;
    float number2;
    float number3;
    float[] numbers;
    float cummulative;

    int counts = 130;
    // Start is called before the first frame update
    void Start()
    {
        numbers = new float[counts];

        for (int i = 0; i < counts; i++)
        {
            numbers[i] = i;
            cummulative += numbers[i];
            Debug.Log(cummulative);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
