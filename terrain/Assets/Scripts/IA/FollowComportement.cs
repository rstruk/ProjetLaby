using UnityEngine;
using System.Collections;

public class FollowComportement : Comportement {

	public override void CalculateDestination(){
		Transform player = GameObject.FindGameObjectWithTag ("Player").transform;
		Vector3 dist = player.position - iapos;
		if (dist.magnitude > 5f)
			destination = player.position;
		else
			destination = iapos;
	//	Debug.Log (destination);
	}
}


