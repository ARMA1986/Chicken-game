﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour {


	public const int maxHealth = 10;
	public int currentHealth = maxHealth;

	public Text hp;
	public Text maxHP;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		hp.text = currentHealth.ToString();
		maxHP.text = maxHealth.ToString();
	}

	public void TakeDamage(int amount){
		currentHealth -= amount;
		if(currentHealth <=0){
			currentHealth=0;
			print ("You're Dead!");
			print ("Game Over");
			// Figure out code to kill or reset postion to the beginning
			// Destroy.gameObject()
		}
	}
}
