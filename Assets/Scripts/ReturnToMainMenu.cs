using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReturnToMainMenu: MonoBehaviour
{
    public Button menuButton;

    void Start()
    {
        menuButton.onClick.AddListener(Game);
    }

    void Game()
    {
        SceneManager.LoadScene(0);
    }
}
