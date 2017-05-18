using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameClearScoreScript : MonoBehaviour {

	public Text ScoreText;

	public Text[] rankingText = new Text[5];

	GameObject FindObject;

	// Use this for initialization
	void Start () {

		FindObject = GameObject.Find ("PointObject");

		PointScript poi = FindObject.GetComponent<PointScript> ();

		ScoreText.text = "SCORE:" + poi.Point.ToString();

		poi.RankingUIText ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
