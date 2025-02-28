﻿using UnityEngine;
using System.Collections;

public class Player : DestroyableObject
{

    float currentSpeed;
    public GameObject lugger;
    public GUIManager guiManager;
    CarController carCon;

    void Awake()
    {
        Time.timeScale = 1;
        carCon = GetComponent<CarController>();
    }

    void Update()
    {
        if (isDead)
        {
            guiManager.hideGUI();
            if(isStill())
                guiManager.playDeathGUI();
        }


    }

    public bool isStill()
    {
        return (lugger.GetComponent<Rigidbody>().velocity.magnitude <= 0.2f);
    }

}


