using UnityEngine;
using System.Collections;

public class teleportation : MonoBehaviour {

	public Transform otherEnd;

	
	// Use this for initialization
	void Start () {
		Debug.Log(this.name);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.name == "player") {
			GameObject player = other.gameObject;
			capsule capsule = player.GetComponent<capsule>();
			if (!capsule.hasJustTeleported) {
				capsule.hasJustTeleported = true;
				capsule.transform.position = otherEnd.position;
			}
			else {
				capsule.hasJustTeleported = false;
			}
		}
	}
}
