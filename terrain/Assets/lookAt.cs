using UnityEngine;
using System.Collections;

public class lookAt : MonoBehaviour {

	private Transform tf;

	// Use this for initialization
	void Start () {
		tf = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		float deltay = Input.GetAxis("Mouse Y");
		tf.Rotate(new Vector3(-deltay, 0f, 0f));
	}
}
