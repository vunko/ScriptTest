﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {        
	private int hp = 100;          // 体力
	private int power = 25; // 攻撃力
	private int mp = 53; // 魔力
	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public  void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}
	public void Magic( int mp ){
		this.mp -= mp;
		if (this.mp < 0) {
			Debug.Log ("ＭＰが足りないため魔法が使えない");
		} else {
			Debug.Log ("魔法攻撃をした。残りＭＰは" + this.mp);
		}	
	}
}

public class Bosstest : MonoBehaviour {

	void Start () {
		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		// 攻撃用の関数を呼び出す
		lastboss.Attack();
		// 防御用の関数を呼び出す
		lastboss.Defence(3);
		for(int i = 0; i < 11; i++){
		lastboss.Magic(5);



		}
	}

	// Update is called once per frame
	void Update () {

	}
}
