using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointScript : MonoBehaviour {

	public int Point;

	public static PointScript Instance = null;

	private int[] ranking = new int[11]{1,3,2,4,9,7,4,6,10,3,20};

	int start,end,tmp,count;

	public Text[] rankingText = new Text[5];

	GameObject FindObject;


	void Awake(){
		if (Instance == null) {
			Instance = this;
			DontDestroyOnLoad (this.gameObject);
			//シーンが変わっても消えない
		} else {
			Destroy (this.gameObject);
			// 2つのGameManagerが存在しないようにする
		}
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}
	//ここの関数でソートをしています。
	public void RankingSort(){

		ranking [0] = Point;
	
		//バブルソートのプログラム　始め
		for (start = 1; start < ranking.Length; start++)
		{
			for (end = ranking.Length-1; end >= start; end--)
			{
				if (ranking[end - 1] > ranking[end])
				{
					tmp = ranking[end - 1];
					ranking[end - 1] = ranking[end];
					ranking[end] = tmp;
				}
			}
		}
		//終わり

		//ランキングがどうなっているのかを表示している
		//５位まで降順で表示させるようにしている
		for (int i = 10; i > 5; i--)
		{
			Debug.Log (" " + ranking [i]);
		}
	}

	public void RankingUIText(){
		count = 0;

		//ランキングがどうなっているのかを表示している
		//５位まで降順で表示させるようにしている
		for (int i = 10; i > 5; i--) 
		{
			Debug.Log (" " + ranking [i]);
			count++;
			Debug.Log ("Score (" + count + ")");
			FindObject = GameObject.Find ("Score (" + count + ")");
			Debug.Log (FindObject.name);

			int now = count - 1;

			rankingText [now] = FindObject.GetComponent<Text> ();

			Debug.Log (rankingText [count - 1]);


		}


		int max = 10;
		int juni = 1;
		for (int a = 0; a < 5; a++) {
			rankingText [a].text =juni + "位 : " + ranking [max].ToString();
			max--;
			juni++;
		}
	}
}
