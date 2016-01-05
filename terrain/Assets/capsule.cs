using UnityEngine;
using System.Collections;

public class capsule : MonoBehaviour {

	public bool hasJustTeleported;
	private Vector3 _speed;
	private Rigidbody rb;
	private Transform tf;
	private float thrust;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		tf = GetComponent<Transform>();
		hasJustTeleported = false;
		thrust = 10f;
	}
	
	// Update is called once per frame
	void Update () {
		_speed =  new Vector3(0f, 0f, 0f);
		
		float deltax = Input.GetAxis("Mouse X");
		rb.angularVelocity = new Vector3(0f, deltax * 2f, 0f);
		
		if (Input.GetKey(KeyCode.UpArrow)) {
			_speed += tf.forward * thrust;
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			_speed -= tf.forward * thrust;
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			_speed -= tf.right * thrust;
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			_speed += tf.right * thrust;
		}
		
		if(Input.GetKey(KeyCode.Space)) {
			_speed += tf.up;
		}
		if (rb.velocity.y == 0f){
			rb.velocity += new Vector3(0f, _speed.y * 5f, 0f);
		}
		
		rb.velocity = new Vector3(_speed.x , rb.velocity.y, _speed.z);	
		Debug.Log(rb.velocity);
	}
}
