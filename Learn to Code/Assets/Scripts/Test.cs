﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    //Properties
    private int experience;

    public int Experience
    {
        get { return experience; }
        set { experience = value; }
    }

    public int Level
    {
        get { return experience / 100; }
        set { experience = value * 100; }
    }


    public static int enemyCount = 0;

    //Generics
    public T GenericMethod<T> (T param) where T : IEnumerable
    {

        return param;
    }


    public string name;
    public int power;

    public Test(string newName, int newPower)
    {
        name = newName;
        power = newPower;
    }











	// Use this for initialization
	void Start () {

        int health = 20;
        string message;

        //Ternary
        message = health > 0 ? "Player is Alive" : "Player is Dead";

        Debug.Log(message);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
