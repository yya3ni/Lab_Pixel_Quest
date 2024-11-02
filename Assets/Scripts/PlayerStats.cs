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
    private const string resapwnTag = "Respawn";
    private const string endGoalTag = "Finish";

    public int playerLife = 3;
    public int coinCount = 0; 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case endGoalTag: {
                    string nextLevel = collision.gameObject.GetComponent<EndGoal>().nextLevel;
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
            case resapwnTag:
                {
                    respawnPoint = collision.transform.Find("RespawnPoint").transform;
                    break;
                }
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
                    if (playerLife < 0)
                    {
                        string currentLevel = SceneManager.GetActiveScene().name; 
                        SceneManager.LoadScene(currentLevel);
                    }
                    break;
                }
                case coinTag:
                {
                    coinCount++;
                    Destroy(collision.gameObject);
                    break;
                }
        }
    }
}
