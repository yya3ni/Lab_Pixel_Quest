using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public Transform respawnPoint;

    private const string deathTag = "Death";

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case deathTag:
                {
                    transform.position = respawnPoint.position;
                    break;
                }
        }
    }
}
