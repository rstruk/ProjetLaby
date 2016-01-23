using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
	public GameObject obstacle;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){
		obstacle.SetActive(!obstacle.activeSelf);
		
	}
}
