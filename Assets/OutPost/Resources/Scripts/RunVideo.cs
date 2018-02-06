using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class RunVideo : MonoBehaviour {
	public Camera camera;
	public Camera maincamera;
	int zoom = 20;
	float smooth = 5;
//	public GameObject follow;
	void Start () {
		maincamera.enabled = false;
	//	cam.enabled = false;
	//	cam1.enabled = true;
//		Debug.Log("Enter");
	//	GameObject camera = GameObject.Find ("Camera");
		//camera.transform.position = follow.transform.position;

//		GetComponent<Renderer>().material.mainTexture = videoPlayer;
//		var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer> ();
//		videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;
//		videoPlayer.targetCameraAlpha = 0.5F;
//		videoPlayer.url = "\\Users\\yinzc\\Downloads\\intro_2.mov";
//		videoPlayer.isLooping = false;
//		videoPlayer.Play ();
//		StartCoroutine (Waitfor());
//		videoPlayer.Stop ();
	}

	IEnumerator Waitfor() {
		yield return new WaitForSeconds (15);

		camera.enabled = true;
		camera.fieldOfView += 5; //Mathf.Lerp(camera.fieldOfView,zoom,Time.deltaTime*smooth);	
	}

	// Update is called once per frame
	void Update () {

	}
}
