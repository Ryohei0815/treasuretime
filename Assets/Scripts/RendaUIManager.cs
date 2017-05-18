using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RendaUIManager : MonoBehaviour {

	public Text RendaText;
	GameObject FindObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		FindObject = GameObject.Find("PointObject");

		PointScript poi = FindObject.GetComponent<PointScript> ();
		RendaText.text = "Score:" + poi.Point.ToString (); //連打カウントを画面に表示する

	}
}
