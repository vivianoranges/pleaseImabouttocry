using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentAnimScript : MonoBehaviour
{
    public Animator animator;
    private bool RightWalk;
    private bool LeftWalk;
    private bool UpWalk;
    private bool DownWalk; 
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("UpWalk", true);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("RightWalk", true);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("LeftWalk", true);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("DownWalk", true);
        }
    }
}
