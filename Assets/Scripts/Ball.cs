using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;
    public int score = 0;
    public Text ScoreText;

    private void OnEnable()
    {
        ScoreText.text = "Score: " + score.ToString();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        //For sprites, substitute SpriteRenderer for MeshRenderer
        objectWidth = transform.GetComponent<MeshRenderer>().bounds.size.x / 2;
        objectHeight = transform.GetComponent<MeshRenderer>().bounds.size.y / 2;

        Respawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < (screenBounds.y * -1 - objectHeight) - 10)
        {
            Respawn();
            score += 100;
            ScoreText.text = "Score: " + score.ToString();
        }
    }

    void Respawn()
    {
        float randomX = Random.Range(screenBounds.x + objectWidth + 10, screenBounds.x * -1 - objectWidth - 10);
        float randomY = Random.Range((screenBounds.y + objectHeight) + 10, (screenBounds.y + objectHeight) + 20);

        transform.position = new Vector3(randomX, 15);
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = Vector3.zero;
    }
}
