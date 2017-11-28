using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBalls : MonoBehaviour {
    public GameObject Ball;

    void Create()
    {
        for (var i = 0; i < 500; i++)
        {
            GameObject g = Instantiate(Ball, new Vector3(Random.Range(-0.5f, 0.5f), 1f, Random.Range(-0.5f,0.5f)), Quaternion.identity) as GameObject;
            Renderer rend = g.GetComponent<Renderer>();
            rend.material.shader = Shader.Find("Standard");
            rend.material.SetColor("_Color", Random.ColorHSV());
        }
    }

	// Use this for initialization
	void Awake () {
        Create();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
