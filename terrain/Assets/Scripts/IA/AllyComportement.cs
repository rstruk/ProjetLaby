using UnityEngine;
using System.Collections;

public class AllyComportement : Comportement {

	public override void CalculateDestination(){
		NavMeshPath path;
		Transform player = GameObject.FindGameObjectWithTag ("Player").transform;
		NavMesh.CalculatePath (player.position, iapos, 0, path);
		path.GetCornersNonAlloc ();
	}
}
