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
    public GameObject projSnake;
    public GameObject projSnake2;
    public GameObject projLizard;
    public GameObject projLizard2;
    public GameObject projDeer;
    public float timeInBetween;
    public int ran;
    private int prevRan;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("CloneRepeating");
        InvokeRepeating("ChangeTime", 15, 15);
    }

    IEnumerator CloneRepeating()
    {
        while (true)
        {
            ChoseClone();
            yield return new WaitForSeconds(time);
        }
    }

    void ChangeTime()
    {
        if (time > 2)
        {
            time -= 0.1f;
        }
        
    }


    // Update is called once per frame   public float timeInBetween = (GameObject.Find("Codey").GetComponent<Move>().health) / 3f);
    void ChoseClone()
    {
        int ran = Random.Range(1, 9);
        while (ran == prevRan) 
        {
            ran = Random.Range(1, 9);
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
        if (ran == 6)
        {
            CloneSnake();
            prevRan = 6;
        }
        if (ran == 7)
        {
            CloneLizard();
            prevRan = 7;
        }
        if (ran == 8)
        {
            CloneDeer();
            prevRan = 8;
        }
    }

    void CloneSpread()
    {
        for (int i = 0; i < 7; i++)
            Instantiate(projSpread, new Vector3(-15 + i * 5.0f, 20, 0), projSpread.transform.rotation);
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
    void CloneSnake()
    {         
        Instantiate(projSnake, new Vector3(-20, 1, 0), projSnake.transform.rotation);
        Instantiate(projSnake2, new Vector3(20, 1, 0), projSnake2.transform.rotation);  
    }
    void CloneLizard()
    {
        Instantiate(projLizard2, new Vector3(-15, 20, 0), Quaternion.identity);
        Instantiate(projLizard2, new Vector3(-13, 22, 0), Quaternion.identity);
        Instantiate(projLizard, new Vector3(14, 20, 0), Quaternion.identity);
        Instantiate(projLizard, new Vector3(12, 22, 0), Quaternion.identity);
    }
    void CloneDeer()
    {
        for (int i = 0; i < 5; i++)
            Instantiate(projDeer, new Vector3(-12 + i * 6, -20, 30), Quaternion.identity);
    }

}
