using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class DeathCamera : MonoBehaviour
{
    public GameObject player;
    public GameObject Camera;
    public int YSpeed;
    public int ZSpeed;
    public int XRotate;
    public Image Fade;
    public int AlphaSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Camera.transform.position = new Vector3(0f, 5.35f, -16.79f);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<PMove>().dead)
        {
            if (Camera.transform.position.y <= 65)
            {
                Camera.transform.Translate(0, YSpeed * Time.deltaTime, -ZSpeed * Time.deltaTime);
                Camera.transform.Rotate(XRotate * Time.deltaTime, 0, 0);
            }
            else
            {
                StartCoroutine(FadeImage(getImageDone =>
                {
                    if (getImageDone)
                    {

                    }
                }));


            }
        }
    }

    private IEnumerator FadeImage(Action<bool> action)
    {
        var alpha = Fade.color.a;
        for (var t = 0.0f; t < 1.0f; t += Time.deltaTime / 2.0f)
        {
            //change color as you want
            var newColor = new Color(0.0f, 0.0f, 0.0f, Mathf.Lerp(alpha, 1f, t));
            Fade.color = newColor;
            yield return null;
            action(Fade.color.a < 0.05f);
        }
    }
}
