using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathSkip : MonoBehaviour
{
    public GameObject player;
    public GameObject Skip;
    // Start is called before the first frame update
    void Start()
    {
        Skip.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<PMove>().dead)
        {
            Skip.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
