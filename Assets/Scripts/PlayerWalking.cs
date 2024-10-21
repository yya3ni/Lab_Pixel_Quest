using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerWalking : MonoBehaviour
{
    Rigidbody2D Rigidbody2D;
    SpriteRenderer spriteRenderer;
    public float Speed = 3; 
    // Start is called before the first frame update
    void Start(){
        Rigidbody2D = GetComponent<Rigidbody2D>(); 
        spriteRenderer = transform.GetChild(0).GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update(){
        float xSpeed = Input.GetAxis("Horizontal");

        if (xSpeed > 0)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }



        Rigidbody2D.velocity = new Vector2(xSpeed * Speed, Rigidbody2D.velocity.y);
    }
}
