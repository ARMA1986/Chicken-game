using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomMove : MonoBehaviour {

// 	public float timer;

// 	public int newtarget;

	public float fSpeed = 4f;

    

// 	public NavMeshAgent nav;

// 	public Vector3 Target;


// 	// Use this for initialization
// 	void Start () {
		
// 		nav = gameObject.GetComponent<NavMeshAgent>();
// 	}
	
// 	// Update is called once per frame
	void Update () {

        transform.localPosition = transform.localPosition + transform.forward * fSpeed 
        * Time.deltaTime;
		
// 		nav.speed = speed;

// 		timer += Time.deltaTime;
// 		if(timer >= newtarget){
// 			newTarget();
// 			timer = 0;
// 		}
	}
// 	void newTarget(){
// 		float myX = gameObject.transform.position.x;
// 		float myZ = gameObject.transform.position.z;

// 		float xPos = myX + Random.Range(myX - 100, myX + 100);
// 		float zPos = myZ + Random.Range(myZ - 100, myZ + 100);

// 		Target = new Vector3 (xPos,gameObject.transform.position.y.zPos);

// 		nav.SetDestination(Target);
// 	}
}
