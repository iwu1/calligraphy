using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    Collider col;
    public bool opaque;

	// Use this for initialization
	void Start ()
    {
        col = GetComponent<Collider>();
        opaque = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
  	}

    //function to 'activate brush'
    public void brush(Collider col)
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            col.isTrigger = true;
        } else
        {
            col.isTrigger = false;
        }
    }

    //function to change material
    public void tracing(Collider col, bool opaque)
    {
        bool active = false;
        if (col.isTrigger == true)
        {
            if (col.CompareTag("Point A"))
            {
                active = true;
                if (active == true && col.CompareTag("Point B"))
                {
                    opaque = true;
                    //GetComponent<Renderer>().material = opaque_material;
                }
            } 
        }
    }
}
