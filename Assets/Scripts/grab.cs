using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity.Interaction;

[RequireComponent(typeof(InteractionBehaviour))]
public class grab : MonoBehaviour
{

    private InteractionBehaviour _intObj;
    public GameObject sphere;

    void Start()
    {
        _intObj = GetComponent<InteractionBehaviour>();
    }

    void Update()
    {
        /*
        if (_intObj.isHovered)
        {
            GameObject t = Instantiate(sphere, new Vector3(0,5,0), Quaternion.identity) as GameObject;
            Renderer rend = t.GetComponent<Renderer>();
            rend.material.shader = Shader.Find("Standard");
            rend.material.SetColor("_Color", Random.ColorHSV());
            Debug.Log("Contact begin!");
        }
        */
    }

    public void GenerateCube()
    {
        Vector3 pos = transform.position;
        GameObject t = Instantiate(sphere, new Vector3(Random.Range(-2f,2f), 0.5f , Random.Range(-2f, 2f)), Quaternion.identity) as GameObject;
        Renderer rend = t.GetComponent<Renderer>();
        rend.material.shader = Shader.Find("Unlit/Color");
        rend.material.SetColor("_Color", Random.ColorHSV());
        Debug.Log("Contact begin!");
    }


}