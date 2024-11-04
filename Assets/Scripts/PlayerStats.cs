using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public Transform respawnPoint;

    private const string deathTag = "Death";
    private const string coinTag = "Coin";
    private const string healthTag = "Health";

    public int playerLife = 3;
    public int currentCoin = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case healthTag:
                {
                    playerLife++;
                    Destroy(collision.gameObject);
                    break;
                }
            case deathTag:
                {
                    transform.position = respawnPoint.position;
                    playerLife--;
                    if (playerLife <= 0)
                    {
                        string thisLevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thisLevel);
                    }
                    break;
                }
            case coinTag:
                {
                    currentCoin++;
                    Destroy(collision.gameObject);
                    break;
                }
        }
    }
        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
