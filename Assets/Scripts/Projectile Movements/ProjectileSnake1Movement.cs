using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSnake1Movement : MonoBehaviour
{
    public float speed;
    public GameObject snake1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-transform.right * speed * Time.deltaTime);
    }
}
