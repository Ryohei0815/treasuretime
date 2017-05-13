using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RendaUIManager : MonoBehaviour {

	public Text RendaText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		RendaText.text = "Score:" + GameManager.Instance.RendaCount.ToString (); //連打カウントを画面に表示する

	}
}
