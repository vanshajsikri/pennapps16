﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (Waitfor());
	}

	IEnumerator Waitfor() {
		yield return new WaitForSeconds(8);
		SceneManager.LoadScene ("Video2");
	}

	// Update is called once per frame
	void Update () {
//		if (Input.GetKey(KeyCode.S))
//			SceneManager.LoadScene ("Video2");
	}
}
