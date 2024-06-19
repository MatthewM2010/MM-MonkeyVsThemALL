using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileWaveMovement : MonoBehaviour
{
    public float speed;
    public GameObject projWave;
    private int dir;
    // Start is called before the first frame update
    void Start()
    {
        dir = 1;  
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((speed - 3) * Time.deltaTime * -1, (speed * Time.deltaTime) * dir, 0);
        if (transform.position.y >= 15)
        {
            dir = -1;
        }
        if (transform.position.y <= 0)
        {
            dir = 1;
        }
    }
}
