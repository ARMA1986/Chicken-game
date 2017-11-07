using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfMove : MonoBehaviour {

	public Rigidbody enemy;

	public float moveSpeed;

	public Transform target;

	public Transform target2;

	// bool behavior;



	void OnTriggerStay(Collider other){

		// if(behavior == true){

//	*********
// 			if (columnname != a 
//   && columnname != b 
//   && columnname != c
//   && (checkbox.checked || columnname != A2)
// {
//    "statement 1"
// }
//	*********

		if(other.gameObject.name == "Player" || other.gameObject.name == "Chicken"){
			Debug.Log("Player has entered wolf's trigger");
			transform.LookAt(target);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}
		
		if(other.gameObject.name == "Chicken" || other.gameObject.name != "Player"){
			Debug.Log("Chicken is now the wolf's target");
			transform.LookAt(target2);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}
		if(other.gameObject.name == "chickenPen" && other.gameObject.name != "Player" 
		&& other.gameObject.name == "Chicken"  ){
			Debug.Log("Wolf is near the chicken pen");
			transform.localPosition = transform.localPosition + -	transform.forward * moveSpeed 
        	* Time.deltaTime;
		}

		else{
			
			transform.localPosition = transform.localPosition + -	transform.forward * moveSpeed 
        	* Time.deltaTime;
			
		}

		// if(other.gameObject.name == "Chicken"){
		// 	Debug.Log("Chicken has entered wolf's trigger");
		// 	transform.LookAt(target2);
		// 	transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		// }
		// else{
		// 	transform.localPosition = transform.localPosition + transform.forward * moveSpeed 
        // 	* Time.deltaTime;
		// }
	}
}
