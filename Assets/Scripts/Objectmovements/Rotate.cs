using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script to rotate a gameobject around itself (y axis)

public class Rotate : MonoBehaviour {

    public float speed;
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0,Time.deltaTime*speed, 0));
    }
}
