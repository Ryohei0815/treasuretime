using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointScript : MonoBehaviour {

	public int Point;

	public static PointScript Instance = null;

	// Use this for initialization
	void Start () {
	
		DontDestroyOnLoad (this.gameObject); //消えない
	}
	
	// Update is called once per frame
	void Update () {

	}
}
