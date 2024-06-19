using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCritterMovement : MonoBehaviour
{
    public float speed;
    public float dir;
    public GameObject projCritter;
    // Start is called before the first frame update
    void Start()
    {
        dir = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * dir, 0, 0);
        if (transform.position.x > 15)
        {
            dir = -1;
        }
        if (transform.position.y < -30)
        {
            Destroy(projCritter);
        }
    }
}
