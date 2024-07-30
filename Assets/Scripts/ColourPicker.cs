using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourPicker : MonoBehaviour
{
    public int Colour;
    public Button def;
    public Button red;
    public Button orange;
    public Button yellow;
    public Button lime;
    public Button green;
    public Button lightBlue;
    public Button blue;
    public Button purple;
    public Button pink;
    public Button brown;
    public Button black;
    // Start is called before the first frame update
    void Start()
    {
        def.onClick.AddListener(Default);
        red.onClick.AddListener(Red);
        orange.onClick.AddListener(Orange);
        yellow.onClick.AddListener(Yellow);
        lime.onClick.AddListener(Lime);
        green.onClick.AddListener(Green);
        lightBlue.onClick.AddListener(LightBlue);
        blue.onClick.AddListener(Blue);
        purple.onClick.AddListener(Purple);
        pink.onClick.AddListener(Pink);
        brown.onClick.AddListener(Brown);
        black.onClick.AddListener(Black);
    }

    void Default()
    {
        Colour = 0;
    }
    void Red()
    {
        Colour = 1;
    }
    void Orange()
    {
        Colour = 2;
    }
    void Yellow()
    {
        Colour = 3;
    }
    void Lime()
    {
        Colour = 4;
    }
    void Green()
    {
        Colour = 5;
    }
    void LightBlue()
    {
        Colour = 6;
    }
    void Blue()
    {
        Colour = 7;
    }
    void Purple()
    {
        Colour = 8;
    }
    void Pink()
    {
        Colour = 9;
    }
    void Brown()
    {
        Colour = 10;
    }
    void Black()
    {
        Colour = 11;
    }

}
