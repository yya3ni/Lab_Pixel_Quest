using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerWalking : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");

        _rigidbody2D.velocity = new Vector2(xInput, _rigidbody2D.velocity.y);
    }
}
