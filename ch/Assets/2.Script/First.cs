using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First : MonoBehaviour
{
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hi");

        Point p = new Point(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("int value : " + i++);
    }
}
