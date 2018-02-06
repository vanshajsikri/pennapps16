using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (WaitFor ());
	}

	IEnumerator WaitFor () {
		yield return new WaitForSeconds(5);
		SceneManager.LoadScene ("NYC6_Scene");
	}
	// Update is called once per frame
	void Update () {
//		if (Input.GetKey(KeyCode.S))
//			SceneManager.LoadScene ("NYC6_Scene");
	}
}
