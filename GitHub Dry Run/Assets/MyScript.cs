using UnityEngine;
using System.Collections;

public class MyScript : MonoBehaviour {


    Color myColor;
    float myTimer;
    public LayerMask[] myLayers;
    public float layerIndex;

	// Use this for initialization
	void Start () {
        //int i = 0;
        foreach (Transform child in transform)
        {
            
        }

        for (int i = 0; i < transform.childCount; i++)
        {
            for (int j = 0; j < layerIndex; j++)
            {
                print(i);
                transform.GetChild(i).gameObject.layer = 8 + j;
            }
        }
	}

    // Update is called once per frame
    void Update()
    {


        myColor = renderer.material.color;
        myTimer += Time.deltaTime;

        myColor = (myTimer < 2) ? myColor = Color.red : myColor = Color.blue;
        myTimer = (myTimer > 4) ? myTimer = 0 : myTimer += Time.deltaTime;

        renderer.material.color = myColor;

        transform.position += new Vector3(Input.GetAxis("Horizontal") * 2.0f, 0, Input.GetAxis("Vertical") * 2.0f);

	}
}
