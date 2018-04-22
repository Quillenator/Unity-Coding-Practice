using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGuy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        List<Test> badguys = new List<Test>();

        badguys.Add(new Test("Jim", 50));
        badguys.Add(new Test("Mike", 5000));
        badguys.Add(new Test("Tim", 500));


        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
