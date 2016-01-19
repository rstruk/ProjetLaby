using UnityEngine;
using System.Collections;

public class nextLevel : MonoBehaviour {

	public int nextlevel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.name == "player") {
			Application.LoadLevel(nextlevel);
		}
	}
}
