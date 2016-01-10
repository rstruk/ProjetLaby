using UnityEngine;
using System.Collections;

public class capsule : MonoBehaviour {

	public bool hasJustTeleported;
	private Vector3 _speed;
	private Rigidbody rb;
	private Transform tf;
	private float thrust;
	private float distToGround; 
 
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		tf = GetComponent<Transform>();
		hasJustTeleported = false;
		thrust = 10f;
		distToGround = GetComponent<Collider>().bounds.extents.y;
		Debug.Log(distToGround);
	}
	
	// Update is called once per frame
	void Update () {
		_speed =  new Vector3(0f, 0f, 0f);
		
		float deltax = Input.GetAxis("Mouse X");
		rb.angularVelocity = new Vector3(0f, deltax * 2f, 0f);
		
		if (Input.GetKey(KeyCode.Z)) {
			_speed += tf.forward * thrust;
		}
		if (Input.GetKey(KeyCode.S)) {
			_speed -= tf.forward * thrust;
		}
		if (Input.GetKey(KeyCode.Q)) {
			_speed -= tf.right * thrust;
		}
		if (Input.GetKey(KeyCode.D)) {
			_speed += tf.right * thrust;
		}
		
		if(Input.GetKey(KeyCode.Space)) {
			_speed += tf.up;
			if (IsGrounded()){
				rb.velocity += new Vector3(0f, _speed.y * 10f, 0f);
			}
		}
		
		rb.velocity = new Vector3(_speed.x , rb.velocity.y, _speed.z);	
	}
	
	bool IsGrounded() {
		bool onfloor = Physics.Raycast(tf.position, -tf.up, (float)distToGround + 0.1f);
		return onfloor;
	}
}
