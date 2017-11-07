using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAI : MonoBehaviour {

	public float moveSpeed;
	public Transform target;
	public int damage;


	void OnTriggerStay(Collider other){
		if(other.gameObject.name == "Player" ){
			Debug.Log("Player has entered wolf's trigger");
			transform.LookAt(target);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}
	}
	// Use this for initialization

	void OnCollisionEnter(Collision other){

		// if(other.gameObject.name == "Player"){

		// 	playerHealth playerHealth = new playerHealth.TakeDamage(damage);

		// 	GetComponent<playerHealth.TakeDamage(damage);

		// }

		print("Wolf is attacking!");

		var hit = other.gameObject;
		var health = hit.GetComponent<playerHealth>();

		if(health != null){
			health.TakeDamage(damage);	
		}
		

	
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
