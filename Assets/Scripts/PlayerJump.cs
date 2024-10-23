using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    public float JumpForce = 10;

    public Transform feetCollider;
    public LayerMask groundMask; 

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, JumpForce);
        }
    }
}
