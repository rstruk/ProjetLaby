using UnityEngine;
using System.Collections;

public class RunAwayComportement : Comportement {

	public override void CalculateDestination(Transform playerDestination){
		destination = new Vector3 (0, 0, 0);
	}
}

