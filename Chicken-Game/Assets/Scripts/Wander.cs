using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour {

public float moveSpeed=1f;

// Gotta think about behaviors for the Wander function
void MoveForward(){
	// transform.Translate(Vector3(0,0,moveSpeed)); OR

	transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);

}

void Turn(){
	// int randomY will create a randomn number
	// the Random.Range() will take parameters between one number and another
	int randomY= Random.Range(0,360);
//  transform.Rotate takes as parameters the x,y,z values in that order
	transform.Rotate(0,randomY,0);
}

void OnTriggerStay(Collider other){
	if (other.gameObject.tag== "CheckPoint"){
		Turn();
	}
	else{
		MoveForward();
	}
}

}
