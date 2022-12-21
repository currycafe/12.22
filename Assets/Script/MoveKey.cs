using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKey : MonoBehaviour
{
    public string parameterName = "";

    void Update()
    {
        bool pushFlag = false;
        if (Input.GetKey("up"))
        {
            pushFlag = true;
        }
        if (Input.GetKey("down"))
        {
            pushFlag = true;
        }
        if (Input.GetKey("left"))
        {
            pushFlag = true;
        }
        if (Input.GetKey("right"))
        {
            pushFlag = true;
        }
        Animator m_Animator = gameObject.GetComponent<Animator>();
        m_Animator.SetBool(parameterName, pushFlag);
    }
}
