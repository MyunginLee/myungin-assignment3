using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForCollectibles : MonoBehaviour
{
    GameObject[] collectibles;
    // Start is called before the first frame update
    void Start()
    {
        float r = 10;
        float x, y;
        collectibles = new GameObject[100];
        for (int i = 0; i < 100; i++)
        {   
            collectibles[i] = GameObject.Instantiate(GameObject.Find("Collectible"));
            x = Mathf.Sin(i / 10f) * r;
            y = Mathf.Cos(i / 10f) * r;
            collectibles[i].transform.position = new Vector3(x, 0, y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
