// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;


// public class Generic : MonoBehaviour {

// // // Position variables: 
// // public float posX=1.5f;
// // public float posY=1.5f;
// // public float posZ=1.5f;

// // // public Vector3 pos;

// // // Rotate variables

// // // public float rotX;
// // // public float rotY;
// // // public float rotZ;
// // // public float rotW;

// // // public Quaternion rot;

// // // Scale variables:

// // // public float x;
// // // public float y;
// // // public float z;

// // // public Vector3 scale;

// // public float moveSpeed=5f;
// // public float turnSpeed=5f; 	
// // void Start(){
// // transform.position = new Vector3(posX,posY,posZ);
// // }

// // void Update(){
// // 		// transform.position = new Vector3(posX,posY,posZ);
// // 		// transform.rotation = new Quaternion(rotX,rotY,rotZ,rotW);
// // 		// transform.localScale = new Vector3(x,y,z); 
		
// // 		// Simplified way replacing the code above:

// // 		// transform.position = pos;
// // 		// transform.rotation = rot;
// // 		// transform.localScale = scale;

// // 		transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
// // 		transform.Rotate(Vector3.right, turnSpeed * Time.deltaTime);

// // 		// transform.localPosition = transform.localPosition + -transform.forward 
// // 		// * moveSpeed * Time.deltaTime;
// // 	}
	

// // }
//  var noTarget = true;
//  var qTo = Quaternion;
//  var speed = 1.25;
//  var rotateSpeed = 3.0;
//  public timer = 0.0f;
 
//  void Start() {
//    qTo = Quaternion.Euler(Vector3(0.0,Random.Range(-180.0, 180.0), 0.0));
 
//  }
 
//  void Update() {
 
//      timer += Time.deltaTime;
 
//      if(noTarget == true) {//when not targeting hero     
//          if(timer > 2) { // timer resets at 2, allowing .5 s to do the rotating
//                qTo = Quaternion.Euler(Vector3(0.0,Random.Range(-180.0, 180.0), 0.0));  
//                timer = 0.0;
//              }
//          transform.rotation = Quaternion.Slerp(transform.rotation, qTo, Time.deltaTime * rotateSpeed);
//          transform.Translate(Vector3.forward * speed * Time.deltaTime);
//      }
//  }
// }