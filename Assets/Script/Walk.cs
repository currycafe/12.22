using UnityEngine;
using System.Collections;

public class Walk : MonoBehaviour
{

    private Animator animator;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * 0.015f;
            animator.SetBool("isWalkingFlag", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * 0.015f;
            animator.SetBool("isWalkingFlag", true);
        }
        else
        {
            animator.SetBool("isWalkingFlag", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0.2f, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -0.2f, 0);
        }
    }



}