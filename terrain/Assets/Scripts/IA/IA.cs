using UnityEngine;
using System.Collections;

public class IA : MonoBehaviour {
	private NavMeshAgent navAgent;
	private NavMesh navMesh;
	private Transform player;
	public Transform playerDestination;
	private Comportement comportement;
	public string comportementType;
	private int timer;
	// Use this for initialization
	void Start () {
		CheckComportement();
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		navAgent = GetComponent<NavMeshAgent> ();
		if (playerDestination == null) {
			playerDestination = transform;
		}
	}

	void CheckComportement(){
		comportement = Comportement.getComportement (comportementType);
	//	comportement = Comportement.getComportement (comportementType);
	}

	// Update is called once per frame
	void Update () {
		comportement = Comportement.getComportement (comportementType);
		comportement.iapos = transform.position;
		if (timer == 0) {
			comportement.CalculateDestination (playerDestination);
			navAgent.SetDestination (comportement.destination);
			timer = comportement.timeBeforeUpdate;
		}
		timer--;

	}
}
