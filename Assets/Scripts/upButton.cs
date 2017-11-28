﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity.Interaction;

public class upButton : MonoBehaviour {
    private InteractionButton _intObj;
    public Transform cam;

    // Use this for initialization
    void Start () {
        _intObj = GetComponent<InteractionButton>();
    }
	
	// Update is called once per frame
	void Update () {
        if (_intObj.isDepressed)
        {
            cam.transform.Translate(Vector3.up * 0.1f);
        }
	}
}
