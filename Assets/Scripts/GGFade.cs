using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GGFade : MonoBehaviour
{
    public Image Fade;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeImage(getImageDone =>
        {
            if (getImageDone)
            {

            }
        }));


    }

    private IEnumerator FadeImage(Action<bool> action)
    {
        var alpha = Fade.color.a;
        for (var t = 0.0f; t < 1.0f; t += Time.deltaTime / 2.0f)
        {
            //change color as you want
            var newColor = new Color(0.0f, 0.0f, 0.0f, Mathf.Lerp(alpha, -1f, t));
            Fade.color = newColor;
            yield return null;
            action(Fade.color.a < 0.05f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
