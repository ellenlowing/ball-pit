using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lift : MonoBehaviour {
    
    private bool isMoving = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Up()
    {
        //isMoving = true;
        //while (isMoving)
        //{
            transform.Translate(Vector3.up * 1f);
        //}
    }

    public void Down()
    {
        //isMoving = true;
        //while (isMoving)
        //{
            transform.Translate(Vector3.down * 1f);
        //}
    }

    public void Pause()
    {
        isMoving = false;
    }
}
