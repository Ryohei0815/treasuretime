using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectScript : MonoBehaviour {

	public GameObject effect;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.Instance.currentMode == Mode.Renda) { //連打モードの時
			if (Input.GetKeyDown (KeyCode.Space)) {
				GenerateEffect ();
			}
		}
	}

	void GenerateEffect (){
		Instantiate (effect, new Vector3(Random.Range(-2.0f,2.0f), Random.Range(1.8f,3.8f),-1f),Quaternion.identity);
	}


}
