using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity.Interaction;

public class expand : MonoBehaviour
{

    private InteractionBehaviour _intObj;

    // Use this for initialization
    void Start()
    {
        _intObj = GetComponent<InteractionBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (_intObj.isGrasped)
        {
            transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
        }
        */
    }

    public void Expand(){
        transform.localScale *= 2;
    }
}
