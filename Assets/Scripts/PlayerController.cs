using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Playerの動きを制御する
public class PlayerController : MonoBehaviour {

	float speed = 3;

	bool rendamode = false;

	int count = 0;

	float timer;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		//モードがExplorationの時
		if (GameManager.Instance.currentMode == Mode.Exploration) {
			Move ();
		}
		//モードがRendaの時
		else if (GameManager.Instance.currentMode == Mode.Renda){

			if (Input.GetKeyDown (KeyCode.Space)) {
				PushRenda ();
			}

			if (Input.GetKeyDown (KeyCode.DownArrow)) {
				GameManager.Instance.ChangeMode (Mode.Combat);
			}

		}

		if (GameManager.Instance.currentMode == Mode.Combat) {
			Move ();
		}

	}

	void Move(){
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position += Vector3.left * speed * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position += Vector3.right * speed * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.position += Vector3.up * speed * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.position += Vector3.down * speed * Time.deltaTime;
		}
	}

	// 連打ボタンを押す
	void PushRenda(){
		GameManager.Instance.AddRendaCount ();

		GenerateEffect ();

	}

	
	void GenerateEffect(){



	}

	//Triggerにぶつかったら呼び出される
	//colはぶつかったものの情報

	void OnTriggerEnter2D (Collider2D col){
		if (col.tag == "Goal") { //Goalにぶつかったときの処理を書く
		} else if (col.tag == "TreasureChest") {　//宝箱にぶつかったときの処理を書く
			//連打モードにしたい
			GameManager.Instance.ChangeMode(Mode.Renda);
			//Destroy (col.gameObject);//ぶつかった物を消す 
		}
	}
}
	