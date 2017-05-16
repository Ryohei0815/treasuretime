using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//ゲーム全体の進行を管理する
public class GameManager : MonoBehaviour {

	public Mode currentMode; //現在のモード

	public static GameManager Instance = null;

	//public int RendaCount = 0;

	public GameObject PointObject;


	void Awake(){
		if (Instance == null) {
			Instance = this;
			DontDestroyOnLoad (this.gameObject);
			//シーンが変わっても消えない
		} else {
			Destroy (this.gameObject);
			// 2つのGameManagerが存在しないようにする
		}

		PointScript poi1 = PointObject.GetComponent<PointScript> ();
		poi1.Point = 0;
			
	}

	// Use this for initialization
	void Start () {
		InitSetting ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void InitSetting(){
		ChangeMode (Mode.Exploration);

	}

	//モードを変えたい時に使う関数
	public void ChangeMode(Mode inputMode){
		currentMode = inputMode;
	}

	//連打するとカウントが増える
	public void AddRendaCount(){
		PointScript poi = PointObject.GetComponent<PointScript> ();
		poi.Point++;

	}
		

}



public enum Mode{
	Exploration, //探検
	Renda, //連打
	Combat //戦闘


}
