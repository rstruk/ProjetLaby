using UnityEngine;
using System.Collections;
using Fungus;

public class fungusEventTrigger : MonoBehaviour {

	public Flowchart flow;
	public string block_name;
	
	// Use this for initialization
	void Start () {
		Debug.Log(this.name);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerExit(Collider other) {
		if (other.gameObject.name == "player") {
			GameObject player = other.gameObject;
			Debug.Log("bla");
			//empêcher le mouvement player
			//empêcher le mouvement caméra
			flow.ExecuteBlock(block_name);
		}
	}
		
}