using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public string nextLevel = "Level_1";

    public void StartGame()
    {
        SceneManager.LoadScene(nextLevel); 
    }
}
