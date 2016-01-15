using UnityEngine;
using System.Collections;

public class RandomComportement : Comportement {

	public override void CalculateDestination(){
		if(Random.Range(0,100) < 90)
			timeBeforeUpdate = 50;
		else
			timeBeforeUpdate = 800;
			
			destination =  iapos + new Vector3 (Random.Range (-1, 2), Random.Range (-1, 2), Random.Range (-1, 2));
	//	Debug.Log (timeBeforeUpdate);

	}
}
