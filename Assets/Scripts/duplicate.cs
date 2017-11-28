using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duplicate : MonoBehaviour {
    public GameObject Ball;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Dup()
    {
            GameObject g = Instantiate(Ball, transform.position, Quaternion.identity) as GameObject;
            Renderer rend = g.GetComponent<Renderer>();
            rend.material.shader = Shader.Find("Standard");
            rend.material.SetColor("_Color", Random.ColorHSV());
    }
}
