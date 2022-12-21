using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Easing : MonoBehaviour
{




    public static float SineIn(float t, float totaltime, float min, float max)
    {
        totaltime = 303;
        min = 0f;
        max = 100f;
        max -= min;
        return -max * Mathf.Cos(t * (Mathf.PI * 90 / 180) / totaltime) + max + min;
    }
}

