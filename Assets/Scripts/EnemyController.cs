using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	public GameObject player; //Playerを定義

	Vector3 playerPoz; //PlayerのPositionをVectorで表す

	float speed = 1f; //Enemyの移動スピードを定義

	void Start (){
		player = GameObject.Find ("Player");　//ゲーム開始時にPlayerを見つける
	}

	void Update(){

		if (GameManager.Instance.currentMode == Mode.Combat) { //戦闘モードの時

			//PlayerのPositionを定義
			playerPoz = player.transform.position;
			//EnemyからPlayerへの方向を指定
			Vector3 vec = playerPoz - transform.position;

			//Enemyはゲーム時間の３fのスピードでPlayerに向かって移動する
			transform.position += vec.normalized * speed * Time.deltaTime;
			//normalizedはWalfからPlayerまでの距離
		}
	}

	void OnTriggerEnter2D (Collider2D col){
		if (GameManager.Instance.currentMode == Mode.Combat) { //戦闘モードの時
			if (col.tag == "Player") { //Playerに当たったら
				col.gameObject.SendMessage ("PlayerDamage"); //"PlayerDamage"と送る
				Camera.main.GetComponent<ObjectShakerScript>().Shake();
				Destroy (this.gameObject); //自分は消える
			}
		}
	}
}