using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawerController : MonoBehaviour {

	public GameObject enemy; //	"enemy"をオブジェクトとして宣言する

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.Instance.currentMode == Mode.Renda) { //連打モードの時
			if (Input.GetKeyDown (KeyCode.Space)) { //スペースキーを押すと
				float random = Random.Range (0.0f, 1.0f); //０～１の中でランダムに数を指定
				if (random < 0.15f) { //指定された数が０．２以下の時
					EnemyGenerate (); //敵を生成
				}
			}
		}
	}

	//敵を生成を制御する
	void EnemyGenerate (){
		Instantiate (enemy, new Vector2(Random.Range(-6.0f,5.8f), Random.Range(-4.5f,2.4f)),Quaternion.identity);
		//指定された座標の範囲内にランダムで敵を生成
	}
}
