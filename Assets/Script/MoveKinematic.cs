using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveKinematic : MonoBehaviour
{
    int counter = 0;
    float move = 0.01f;

    void Update()
    {
        Vector3 p = new Vector3(0, 0, 0);
        transform.Translate(p);
        counter++;

        if (counter == 300)
        {
            counter = 0;
            move *= -1;
        }
    }
}
