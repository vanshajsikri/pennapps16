using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain_overheard : MonoBehaviour {
	public GameObject rain;
	public Camera camera;
	public Vector3 offset;
	// Use this for initialization
	void Start () {
		rain.transform.position = camera.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		rain.transform.position = offset + camera.transform.position;
	}
}
