using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	public GameObject player;

	float speed = 3f;

	void Start (){
		GameObject.Find ("Player");
	}

	void Update(){
		/*transform.LookAt (new Vector3 (player.transform.position.x, player.transform.position.y, 0));*/
		Quaternion FromToRotation (new Vector3 (fromDirection, Vector3 toDirection));
		transform.position += transform.forward * speed * Time.deltaTime;
	}
}

	/*public Transform target;
	UnityEngine.AI.NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		GameObject player = GameObject.Find ("Player");
		target = player.transform;
		agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		agent.SetDestination(target.position);

	}*/

	/*private float speed = 10f;

	private float rotationSmooth = 1f;

	private Vector2 targetPosition;

	private float changeTargetSqrDistance = 40f;

	private void Start(){
		targetPosition = GetRandomPositionOnLevel();
		}
		
	private void Update(){
		// 目標地点との距離が小さければ、次のランダムな目標地点を設定する
		float sqrDistanceToTarget = Vector2.SqrMagnitude(targetPosition);
		if (sqrDistanceToTarget < changeTargetSqrDistance){
			targetPosition = GetRandomPositionOnLevel();

		}

		// 目標地点の方向を向く
		Quaternion targetRotation = Quaternion.LookRotation(transform.position);
		transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSmooth);

		// 前方に進む
		transform.Translate(Vector2.up * speed * Time.deltaTime);
		}

	public Vector2 GetRandomPositionOnLevel()
	{
			float levelSize = 55f;
			return new Vector2(Random.Range(-levelSize, levelSize),Random.Range(-levelSize, levelSize));
	}*/

	/*public Transform target;

	void Start () {
		GameObject player = GameObject.Find ("Player");
	}

	public void MoveEnemy (){

		int xDir = 0;

		int yDir = 0;

		//同じカラム(x軸)にいる時

		//Mathf.Abs: 絶対値をとる。-1なら1となる。

		if (Mathf.Abs (target.position.x - transform.position.x) < float.Epsilon) {

			//プレイヤーが上にいれば+1、下に入れば-1する

			yDir = target.position.y > transform.position.y ? 1 : -1;

		} else {

			//プレイヤーが右にいれば+1、左にいれば-1する

			xDir = target.position.x > transform.position.x ? 1 : -1;

		}

	}
}*/


