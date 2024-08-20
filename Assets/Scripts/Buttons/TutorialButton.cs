using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TutorialButton : MonoBehaviour
{
    public Button Tutorial;

    void Start()
    {
        Tutorial.onClick.AddListener(Game);
    }

    void Game()
    {
        SceneManager.LoadScene(4);
    }
}
