using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleMove : MonoBehaviour
{
    public GameObject Title;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = new Quaternion(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Title.transform.Rotate(0, 0, speed * Time.deltaTime);
        if (Title.transform.rotation.z >= 3)
        {
            speed = 0 - speed;
            Debug.Log("change dir");
        }
        if (Title.transform.rotation.z <= -3)
        {
            speed = 0 - speed;
            Debug.Log("change DIR");
        }
    }
}
