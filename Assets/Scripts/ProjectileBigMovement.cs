using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBigMovement : MonoBehaviour
{
    public float speed;
    public GameObject projBig;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime,0,0);
    }
}
