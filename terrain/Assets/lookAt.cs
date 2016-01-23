using UnityEngine;
using System.Collections;
using Fungus;

public class lookAt : MonoBehaviour {

	public Flowchart flow;
	private Transform tf;

	// Use this for initialization
	void Start () {
		flow.SetBooleanVariable("isSpeaking", false);
		tf = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		if(flow.GetBooleanVariable("isSpeaking") == false){
			float deltay = Input.GetAxis("Mouse Y");
			tf.Rotate(new Vector3(-deltay, 0f, 0f));
		}
	}
}
