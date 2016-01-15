using UnityEngine;
using System.Collections;

public class AllyComportement : Comportement {

	public override void CalculateDestination(){
		NavMeshPath path = new NavMeshPath();
		Transform player = GameObject.FindGameObjectWithTag ("Player").transform;
		NavMesh.CalculatePath (player.position, iapos, 0, path);
		Vector3[] corners = new Vector3[1000];
		path.GetCornersNonAlloc(corners);

	}
}
