using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ProjectileLava : MonoBehaviour
{
    public float speed;
    private float dir;
    public GameObject projLava;
    // Start is called before the first frame update
    void Start()
    {
        dir = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime * dir, 0);
        if (transform.position.y > -4.75)
        {
            dir = -1;
        }
        if (transform.position.y < -12)
        {
            Destroy(projLava);
        }
        //if (transform.position.y < -5)
        //{
        //    transform.Translate(0, speed * Time.deltaTime, 0);
        //}
        //else
        //{
        //    transform.Translate(0, speed * Time.deltaTime, 0);
        //    if (transform.position.y < -12)
        //    {
        //        Destroy(projLava);
        //    }
        //}
    }
}
