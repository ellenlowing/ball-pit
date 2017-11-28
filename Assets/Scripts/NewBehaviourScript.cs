using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
	}
    


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
