using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    public float JumpForce = 10;

    public Transform feetCollider;
    public LayerMask groundMask;

    private bool waterCheck;
    private string waterTag = "Water";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == waterTag)
        {
            waterCheck = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == waterTag)
        {
            waterCheck = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        bool groundCheck = Physics2D.OverlapCapsule(feetCollider.position, new Vector2(1, 0.08f), CapsuleDirection2D.Horizontal, 0, groundMask);

        if (Input.GetKeyDown(KeyCode.Space) && (groundCheck || waterCheck))
        {

            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, JumpForce);
        }
    }
}
