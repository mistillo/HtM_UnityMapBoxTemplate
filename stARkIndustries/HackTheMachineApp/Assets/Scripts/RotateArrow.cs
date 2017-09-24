using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateArrow : MonoBehaviour {

    // Use this for initialization
    public Transform followObject;
	void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {

        float y = followObject.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, y, 90);
        transform.rotation = rotation;
		
	}
}
