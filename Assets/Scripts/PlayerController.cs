using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//Playerの動きを制御する
public class PlayerController : MonoBehaviour {

	float speed = 3; //Playerの動くスピード
	public int playerHP = 3; //Playerの体力
	float timer;
	public GameObject PlayerHeart;
	public GameObject PlayerHeart1;
	public GameObject order1;
	public GameObject order2;

	GameObject FindObject;

	/*bool rendamode = false;
	int count = 0;*/

	// Use this for initialization
	void Start () {

		FindObject = GameObject.Find("PointObject");

		PointScript poi = FindObject.GetComponent<PointScript> ();
		poi.Point = 0;

		GameManager.Instance.ChangeMode (Mode.Exploration);

	}
	
	// Update is called once per frame
	void Update () {


		//モードがExplorationの時
		if (GameManager.Instance.currentMode == Mode.Exploration) {
			Move ();
		}
		//モードがRendaの時
		else if (GameManager.Instance.currentMode == Mode.Renda){

			if (Input.GetKeyDown (KeyCode.Space)) { // スペースキーで連打する
				PushRenda ();
			}

			if (Input.GetKeyDown (KeyCode.DownArrow)) { // 下キーで戦闘モードに移行する
				GameManager.Instance.ChangeMode (Mode.Combat);

				Instantiate (order2, new Vector2(-4.1f,-4.22f),Quaternion.identity);
			}

		}
		//モードがCombatの時
		if (GameManager.Instance.currentMode == Mode.Combat) {
			Move ();
		}

	}

	// プレイヤーの動きを制御する
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
		GameManager.Instance.AddRendaCount (); // 連打カウントを増やす

		GenerateEffect ();

	}

	
	void GenerateEffect(){



	}

	//Triggerにぶつかったら呼び出される
	//colはぶつかったものの情報

	void OnTriggerEnter2D (Collider2D col){
		if(GameManager.Instance.currentMode == Mode.Combat){
			if (col.tag == "Goal") {//Goalにぶつかったときの処理を書く
				FindObject = GameObject.Find("PointObject");

				PointScript poi = FindObject.GetComponent<PointScript> ();

				poi.RankingSort ();

				SceneManager.LoadScene("Game Clear"); //ゲームクリア画面に移行する
			}
		}

		else if (col.tag == "TreasureChest") {　//宝箱にぶつかったときの処理を書く
			//連打モードにしたい
			GameManager.Instance.ChangeMode(Mode.Renda); //連打モードに移行する

			Instantiate (order1, new Vector2(0.3f,4.47f),Quaternion.identity);

			/*if(Instantiate (order, new Vector2(5.0f,4.41f),Quaternion.identity)){
				Destroy (order.gameObject, 1.0f);
			}*/                                                                                       
			//Invoke ("orderdestroy", 1.0f);
		}

		if (col.tag == "Key") {
			Destroy (col.gameObject);
		}
	}

	//void orderdestroy (){
	//	Destroy (order);
	//}

	void PlayerDamage (){
		playerHP--;
		if (playerHP <= 0) {
			SceneManager.LoadScene ("Game Over");
		}
		if (playerHP <= 2) {
			Destroy (PlayerHeart);
		}
		if (playerHP <= 1) {
			Destroy (PlayerHeart1);
		}
	}
}
	