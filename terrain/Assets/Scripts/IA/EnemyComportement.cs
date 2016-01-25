using UnityEngine;
using System.Collections;

public class EnemyComportement : Comportement {

	public override void CalculateDestination(Transform playerDestination){
		Vector3 PDest = iapos;
		if(playerDestination != null)
			PDest = playerDestination.position;
		destination = iapos;
		NavMeshPath path = new NavMeshPath ();
		Transform player = GameObject.FindGameObjectWithTag ("Player").transform;
		NavMesh.CalculatePath (player.position, PDest , NavMesh.AllAreas, path);
		Vector3[] corners = new Vector3[100];
		int nbCorners = path.GetCornersNonAlloc (corners);
		GameObject[] obstacleSwitchs = GameObject.FindGameObjectsWithTag ("ObstacleSwitch");
		float initialDist = 0.0f;
		for (int i = 1; i < nbCorners; i++) {
			Vector3 diff = corners [i] - corners [i - 1];
			initialDist += diff.magnitude;
		}
		Debug.Log (initialDist);
		float nextDist = 0.0f;
		foreach (GameObject go in obstacleSwitchs) {
			nextDist = 0.0f;
			GameObject obstacle = go.GetComponent<Obstacle> ().obstacle;
			obstacle.SetActive (!obstacle.activeSelf);
			NavMesh.CalculatePath (player.position, iapos, 1, path);
			Vector3[] corners2 = new Vector3[1000];
			nbCorners = path.GetCornersNonAlloc (corners2);
			for (int i = 1; i < nbCorners; i++) {
				Vector3 diff = corners2 [i] - corners2 [i - 1];
				nextDist += diff.magnitude;
			}
			obstacle.SetActive (!obstacle.activeSelf);
			if (nextDist > initialDist) {
				destination = go.transform.position;
				initialDist = nextDist;
			}
		

		}
		//Debug.Log (nbCorners);
	
	}
}

