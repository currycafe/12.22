using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    public string targetObjectName;
    public float speed = 1;
    GameObject targetObject;


    void Start()
    {
        targetObject = GameObject.Find(targetObjectName);
    }

    private void FixedUpdate()
    {
        Vector3 dir = (targetObject.transform.position - this.transform.position).normalized;

        float vx=dir.x*speed;
        float vz=dir.z*speed;
        this.transform.Translate(vx / 50, 0, vz / 50);
    }
}
