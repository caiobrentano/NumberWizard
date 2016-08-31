﻿using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			min = guess;
			NextGuess();
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			NextGuess();
		}
		else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("I won!");
			print ("========== END ===========");

			StartGame();
		}
	}

	void StartGame() {
		min = 1;
		max = 1000;
		guess = 500;

		print ("Welcome to Number Wizard!");
		print ("Pick a number in your head, but don't tell me!");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
//		print ("Is the number higher or lower than " + guess + "?");
//		print ("Up = higher, down = lower, return = equal");
		NextGuess();
		
		max = max + 1;
	}

	void NextGuess() {
		guess = (max + min) / 2;
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up = higher, down = lower, return = equal");
	}
}
