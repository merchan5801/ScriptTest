using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 配列を初期化する
		int[] points = {10, 20, 30, 40, 50,};

		// 配列の要素数の正順で表示する
		for (int i = 0; i < points.Length; i++)
			   Debug.Log (points [i]);
		
		// 配列の要素数を逆順にする
		for (int i = points.Length-1; 0 <= i; i--) {
			   Debug.Log (points [i]);
			
		}

	}

	// Update is called once per frame
	void Update () {

	}
}