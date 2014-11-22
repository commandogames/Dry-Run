using UnityEngine;
using System.Collections;

public class MyScript : MonoBehaviour {


    Color myColor;
    float myTimer;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


        myColor = renderer.material.color;
        myTimer += Time.deltaTime;

        myColor = (myTimer < 2) ? myColor = Color.red : myColor = Color.blue;
        myTimer = (myTimer > 4) ? myTimer = 0 : myTimer += Time.deltaTime;

        renderer.material.color = myColor;
        

	}
}
