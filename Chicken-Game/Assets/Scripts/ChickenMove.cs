using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenMove : MonoBehaviour {

	public Rigidbody enemy;

	public float moveSpeed=2f;

	public float turnSpeed=0.1f;

	// public float fSpeed = 4f;

	public Transform target1;

	public Transform target2;

	public Transform chickenPen;

	public int points = 10;

	// public Transform from;

	// public Transform to;

 	public float smooth = 2.0F;
    public float tiltAngle = 3.0F;




	



	// public float timer;

	// public int newTarget;

	// public float speed;

	// public NavMeshAgent nav;

	// public Vector3 Target;


	// private float timeToChangeDirection;

	// void Start(){
	// 	chickenPen = gameObject.Find("chickenPen");
	// }
	
	void OnTriggerStay(Collider other){

		if(other.gameObject.name == "Player"){
			Debug.Log("Player has entered chicken's trigger");
			transform.LookAt(target1);
			transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
			
		}
		if(other.gameObject.name == "Wolf"){
			Debug.Log("Wolf has entered chicken's trigger");
			transform.LookAt(target2);
			transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
		}
	}
		
	void OnCollisionEnter(Collision other){

		if(other.gameObject.name== "Player"){
			Debug.Log("Player has caught a chicken");
			// Destroy(gameObject);
			// Add points to score
			scoreManager.AddPoints(points);
			// Send chicken to chicken pen
			transform.position = chickenPen.position;
			transform.rotation = chickenPen.rotation;
		}
	
	}

	

	void Update () {

        // transform.Rotate(Vector3.right,Time.deltaTime,Space.World);
		transform.localPosition = transform.localPosition + -transform.forward 
		* moveSpeed * Time.deltaTime;
		// transform.rotation = Quaternion.Lerp(from.rotation, to.rotation, Time.time * turnSpeed);
		
        // float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        // float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;
        // Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
        // transform.rotation = Quaternion.Slerp(transform.rotation, target, 
		// Time.deltaTime * smooth);

		// float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;
        Quaternion target = Quaternion.Euler(0, tiltAroundX,0);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, 
		Time.deltaTime * 3* smooth);
		// Quaternion rotation = Quaternion.Euler(new Vector3(0, 30, 0));
    }
}
	

	// 	public void Start () {

	// 		nav = gameObject.GetComponent<NavMeshAgent>();
    //     // ChangeDirection();
    // }
     
     
    // public void Update () {

	// 	nav.speed = speed;

	// 	timer += Time.deltaTime;
	// 	if(timer >= newTarget){
	// 		newTarget();
	// 		timer = 0;
	// 	}
    //     timeToChangeDirection -= Time.deltaTime;
 
    //     if (timeToChangeDirection <= 0) {
    //          ChangeDirection();
    //     }
 
    //     GetComponent<rigidbody>() = transform.up * 2;
    // }

	// private void ChangeDirection() {
    //     float angle = Random.Range(0f, 360f);
    //     Quaternion quat = Quaternion.AngleAxis(angle, Vector3.forward);
    //     Vector3 newUp = quat * Vector3.up;
    //     newUp.z = 0;
    //     newUp.Normalize();
    //     transform.up = newUp;
    //     timeToChangeDirection = 1.5f;
    // }

	// void newTarget(){
	// 	float myX = gameObject.transform.position.x;
	// 	float myZ = gameObject.transform.position.z;

	// 	float xPos = myX + Random.Range(myX - 100, myX + 100);
	// 	float zPos = myZ + Random.Range(myZ - 100, myZ + 100);

	// 	Target = new Vector3 (xPos, gameObject.transform.position.y.zPos);

	// 	nav.SetDestination(Target);
	// }

