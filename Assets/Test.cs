﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
	void Start () {
		int[] array = new int[5];

		array [0] = 1;
		array [1] = 2;
		array [2] = 3;
		array [3] = 4;
		array [4] = 5;
		for (int i = 4; 0 <= i; i--) {
			Debug.Log (array [i]);
		
		}
		for (int i = 0; 4 >= i; i++) {
			Debug.Log (array [i]);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}