using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {

	public float moveSpeed;

	public Transform target;
	
	// Transform is to get the x y z coordinates

	// Target is to find our target's position
	public Transform chickenPen;

	// a trigger 
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.name== "Player"){
			// Debug.Log("Player has entered chickens trigger");
			// transform.LookAt(target);
			// transform.Translate(Vector3.back*moveSpeed*Time.deltaTime );
			transform.position = chickenPen.position;
			transform.rotation = chickenPen.rotation;
		}

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
