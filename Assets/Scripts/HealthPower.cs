using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPower : MonoBehaviour
{
    public GameObject hp;
    int ran;

    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;
    // Start is called before the first frame update
    private void OnEnable()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        objectWidth = transform.GetComponent<MeshRenderer>().bounds.size.x / 2;
        objectHeight = transform.GetComponent<MeshRenderer>().bounds.size.y / 2;
    }

    void Start()
    {
        InvokeRepeating("SpawnClone", 6f, 10f);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("trigger");
            hp.SetActive(false);
        }
    }

// Update is called once per frame
    void SpawnClone()
    {
        hp.SetActive(true);
        float randomX = Random.Range(screenBounds.x + objectWidth + 1, screenBounds.x * -1 - objectWidth - 1);
        float randomY = Random.Range((screenBounds.y + objectHeight) + 4, (screenBounds.y + objectHeight) + 4);

        transform.position = new Vector3(randomX, randomY);
    }
}
