using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfMove : MonoBehaviour {

	public Rigidbody enemy;

	public float moveSpeed;

	public Transform target;

	public Transform target2;



	void OnTriggerStay(Collider other){

		if(other.gameObject.name == "Player"){
			Debug.Log("Player has entered wolf's trigger");
			transform.LookAt(target);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}

		if(other.gameObject.name == "Chicken"){
			Debug.Log("Chicken has entered wolf's trigger");
			transform.LookAt(target2);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}
	}
}
