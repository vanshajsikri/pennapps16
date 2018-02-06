using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class submitHandler : MonoBehaviour {

    private Canvas pref;

	// Use this for initialization
	void Start () {
        pref = GameObject.Find("preferencesCanvas").GetComponent<Canvas>();
        
	}
	
	// Update is called once per frame
	void Update () {
        pref = GameObject.Find("preferencesCanvas").GetComponent<Canvas>();
        if (Input.GetKeyDown(KeyCode.X))
        {
            pref.enabled = false;
        }
	}
}
