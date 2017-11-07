using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Generic : MonoBehaviour {

// Position variables: 
// public float posX=1.5f;
// public float posY=1.5f;
// public float posZ;

public Vector3 pos;



// Rotate variables

// public float rotX;
// public float rotY;
// public float rotZ;
// public float rotW;

public Quaternion rot;

// Scale variables:

// public float x;
// public float y;
// public float z;

public Vector3 scale;

void Update(){
		// transform.position = new Vector3(posX,posY,posZ);
		// transform.rotation = new Quaternion(rotX,rotY,rotZ,rotW);
		// transform.localScale = new Vector3(x,y,z); 
		
		// Simplified way replacing the code above:

		transform.translate = pos;
		transform.rotate = rot;
		transform.localScale = scale;
	}
	

}
