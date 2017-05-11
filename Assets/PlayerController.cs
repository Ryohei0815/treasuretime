using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	float speed = 3;

	bool rendamode = false;

	int count = 0;

	float timer;

	int Mode = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position += Vector3.left * speed * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position += Vector3.right * speed * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.position += Vector3.up * speed * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.position += Vector3.down * speed * Time.deltaTime;
		}

		if (rendamode) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				PushRenda ();
			}


	
			
		
		}
	}

	// 連打ボタンを押す
	void PushRenda(){
			
		count++;

		GenerateEffect ();

	}

	
	void GenerateEffect(){



	}

	void OnTriggerEnter2D (Collider2D col){
		if (col.tag == "Goal") {
		}
	}
}
