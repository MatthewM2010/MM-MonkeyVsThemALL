using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawn : MonoBehaviour
{
    public GameObject projSpread;
    public GameObject projBig;
    public GameObject projWave;
    public GameObject projLava;
    public GameObject projCritter;
    public float timeInBetween;
    public int ran;
    private int prevRan;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ChoseClone", 5f, 5f);
    }

    // Update is called once per frame   public float timeInBetween = (GameObject.Find("Codey").GetComponent<Move>().health) / 3f);
    void ChoseClone()
    {
        int ran = Random.Range(1, 6);
        while (ran == prevRan) 
        {
            ran = Random.Range(1, 6);
            Debug.Log("reran");
        }
        if (ran == 1)
        {
            CloneSpread();
            prevRan = 1;
        }
        if (ran == 2)
        {
            CloneBig();
            prevRan = 2;
        }
        if (ran == 3)
        {
            CloneWave();
            prevRan = 3;
        }
        if (ran == 4)
        {
            CloneLava();
            prevRan = 4;
        }
        if (ran == 5)
        {
            CloneCritter();
            prevRan = 5;
        }
    }

    void CloneSpread()
    {
        for (int i = 0; i < 7; i++)
            Instantiate(projSpread, new Vector3(-15 + i * 5.0f, 20, 0), Quaternion.identity);
    }

    void CloneBig()
    {
        for (int i = 0; i < 3; i++)
            Instantiate(projBig, new Vector3(-20 - i * 20, 1, 0), Quaternion.identity);
    }

    void CloneWave()
    {
        for (int i = 0; i < 7; i++)
            Instantiate(projWave, new Vector3(20 + i, 0 + i , 0), Quaternion.identity);
    }
    void CloneLava()
    {
        for (int i = 0; i < 1; i++)
            Instantiate(projLava, new Vector3(0, -12, 0), Quaternion.identity);
    }
    void CloneCritter()
    {
        for (int i = 0; i < 5; i++)
            Instantiate(projCritter, new Vector3(-20 - i * 2, 0, 0), Quaternion.identity);
    }
}
