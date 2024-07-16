using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToShopMenu : MonoBehaviour
{

    public Button shopButton;

    void Start()
    {
        shopButton.onClick.AddListener(Game);
    }

    void Game()
    {
        SceneManager.LoadScene(3);
    }
}
