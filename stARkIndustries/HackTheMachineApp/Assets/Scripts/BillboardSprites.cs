﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardSprites : MonoBehaviour {
    public Transform cam;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(cam.transform);

    }
}
