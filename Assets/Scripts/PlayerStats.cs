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

    public float playerLife = 3;
    public float playerMaxLife = 3; 
    public int coinCount = 0;
    private int maxCoins; 

    private UIController _uiController;
    public GameObject coinParent; 

    private void Start()
    {
        _uiController = GetComponent<UIController>();
        maxCoins = coinParent.transform.childCount;
        _uiController.UpdateCoinText(coinCount + "/" + maxCoins);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case coinTag:
                {
                    coinCount++;
                    _uiController.UpdateCoinText(coinCount + "/" + maxCoins);
                    Destroy(collision.gameObject);
                    break;
                }
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
                    if(playerLife < playerMaxLife)
                    {
                        playerLife++;
                        _uiController.UpdateHeartImage((float)playerLife / (float)playerMaxLife);
                        Destroy(collision.gameObject);
                    }
                    break;
                }
            case deathTag:
                {
                    transform.position = respawnPoint.position;
                    playerLife--;
                    _uiController.UpdateHeartImage((float)playerLife / (float)playerMaxLife);
                    if (playerLife < 0)
                    {
                        string currentLevel = SceneManager.GetActiveScene().name; 
                        SceneManager.LoadScene(currentLevel);
                    }
                    break;
                }
  
        }
    }
}
