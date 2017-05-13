using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUIManager : MonoBehaviour {


	float time = 20; //制限時間を設定する

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = "Time Limit:" + ((int)time).ToString ();	
	}
	
	// Update is called once per frame
	void Update () {

		time -= Time.deltaTime; //時間を減らしていく

		//時間が０以下にならないようにする
		if (time < 0) {
			time = 0;
		}
		GetComponent<Text> ().text = "Time Limit:" + ((int)time).ToString ();
		
	}
}
