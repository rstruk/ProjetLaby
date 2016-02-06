using UnityEngine;
using System.Collections;
using Fungus;

public class fungusEventTriggerCond : MonoBehaviour {

	public Flowchart flow;
	static string firstMet;
	public string couleur; 

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
			Debug.Log("bla");
			
			if(firstMet == null) {
				firstMet = couleur;
				flow.ExecuteBlock("BleuOuRoujeMeet");
			}
			
			if(firstMet == "bleu"){
				flow.ExecuteBlock("SferbleuMeet");
			}
			else if (firstMet == "rouje"){
				flow.ExecuteBlock("RonroujeMeet");
			}
			
		}
	}
}