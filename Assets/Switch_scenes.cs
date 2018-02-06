using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Switch_scenes : MonoBehaviour {
	public Button Sunny, Rainy, Snow;

	// Use this for initialization

	void Start () {
//		Image img = GameObject.Find ("Panel").GetComponent<Image> ();
//		img.color = Color.red;
		Button sunny = Sunny.GetComponent<Button> ();
		Button rainy = Rainy.GetComponent<Button> ();
		Button snow = Snow.GetComponent<Button> ();

		sunny.onClick.AddListener (HandleClicksunny);
		rainy.onClick.AddListener (HandleClickrainy);
		snow.onClick.AddListener (HandleClicksnow);
	}

	void HandleClicksunny () {
		SceneManager.LoadScene ("NYC6_Scene");
	}
	void HandleClickrainy () {
		SceneManager.LoadScene ("NYC6_Scene_rain");
	}
	void HandleClicksnow () {
		SceneManager.LoadScene ("NYC6_Scene_snow");
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A))
			SceneManager.LoadScene ("NYC6_Scene_snow");
		if (Input.GetKey(KeyCode.D))
			SceneManager.LoadScene ("NYC6_Scene_rain");
	}
}
