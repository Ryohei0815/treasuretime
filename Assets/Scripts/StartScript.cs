using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Invoke ("Mainscene",1.0f); //1秒後に処理を行う
		
	}

	void Mainscene(){
		SceneManager.LoadScene ("main");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
