using UnityEngine;
using System.Collections;
using Fungus;

public class FollowComportement : Comportement {

	public override void CalculateDestination(Transform playerDestination){
		Flowchart flow = GameObject.FindGameObjectWithTag ("Player").GetComponent<capsule>().flow;
		if ( flow.GetIntegerVariable ("Boulvertes") > 0) {

		Transform player = GameObject.FindGameObjectWithTag ("Player").transform;
		Vector3 dist = player.position - iapos;
		if (dist.magnitude > 5f)
			destination = player.position;
		else
			destination = iapos;
	//	Debug.Log (destination);
		}
		else
			destination = new Vector3 (0, 0, 0);
		
}


