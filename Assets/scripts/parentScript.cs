using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parentScript : MonoBehaviour {
    bool Atriggered;
    //bool Btriggered;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger))
        {
            Atriggered = false;
        }
	}


    public void childTriggered(string name)
    {
        if (name.Contains("a") && OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            Atriggered = true;
        }else if (name.Contains("b") && Atriggered == true && OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            Debug.Log("IT WORKED");
        }
    }

    
}
