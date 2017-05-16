using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RendaUIManager : MonoBehaviour {

	public Text RendaText;
	public GameObject PointObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		PointScript poi = PointObject.GetComponent<PointScript> ();
		RendaText.text = "Score:" + poi.Point.ToString (); //連打カウントを画面に表示する

	}
}
