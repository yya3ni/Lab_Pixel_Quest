using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    private Animator animator;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (rigidbody2D.velocity.x == 0) {
            animator.SetBool("isWalking", false);
        }
        else  {
            animator.SetBool("isWalking", true);
        }
    }
}
