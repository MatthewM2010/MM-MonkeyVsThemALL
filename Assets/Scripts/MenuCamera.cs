using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCamera : MonoBehaviour
{
    public GameObject cam;
    public int Speed = 6;
    private int dir;
    // Start is called before the first frame update
    void Start()
    {
        Speed = 6;
        transform.position = new Vector3(118, 20, 97);
        transform.rotation = new Quaternion(0, 0, 0, 0);
        dir = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((Speed * Time.deltaTime) * dir, 0, 0);
        transform.Rotate(1 * Time.deltaTime * dir, 0, (1 / 2) * Time.deltaTime * dir);
        if(cam.transform.position.x >= 200)
        {
            dir = -1;
        }
        if (cam.transform.position.x <= -23)
        {
            dir = 1;
        }
    }
}
