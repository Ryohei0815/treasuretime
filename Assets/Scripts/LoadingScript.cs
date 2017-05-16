using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScript : MonoBehaviour {

	public GameObject Canvas;
	public GameObject Canvas1;
	public GameObject Canvas2;
	private int LoadingCanvas;

	// Use this for initialization
	void Start () {

		Canvas.SetActive (false);
		Canvas1.SetActive (false);
		Canvas2.SetActive (false);

		LoadingCanvas = Random.Range (0, 2);
		if (LoadingCanvas == 0) {
			Canvas.SetActive (true);
		}
		if (LoadingCanvas == 1) {
			Canvas1.SetActive (true);
		}
		if (LoadingCanvas == 2) {
			Canvas2.SetActive (true);
		}

		Invoke ("NextScene",5.0f);

	}

	void NextScene(){
		SceneManager.LoadScene ("Start");
	}
	
	// Update is called once per frame
	void Update () {



	}
}
