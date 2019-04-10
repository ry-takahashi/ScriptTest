using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

		// 配列を作成、初期化
		int[] array = { 2, 3, 5, 7, 11 };

		// 順番に表示
		for (int i = 0; i < array.Length; i++) {

			Debug.Log (array [i]);
		}

		// 逆順に表示
		for (int i = 0; i < array.Length; i++) {

			Debug.Log (array [ ( array.Length - 1) - i]);
		}

		// Boss
		Boss lastBoss = new Boss();

		// 魔法を使う(10回)
		for( int i = 0; i < 10; i++ ){
			lastBoss.Magic ();
		}

		// さらに魔法を使う
		lastBoss.Magic();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class Boss {
	
	int hp = 100;		// 体力
	int power = 25;		// 攻撃力
	int mp = 53;		// MP(魔力)

	// 攻撃用の関数
	public void Attack() {		
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public void Defence( int damage ) {
		Debug.Log( damage+"のダメージを受けた" );
		this.hp -= damage;
	}

	// 魔法攻撃用の関数
	public void Magic() {

		// MPが足りているか
		if (this.mp >= 5) {
			this.mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");

		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}

			

	}

}

