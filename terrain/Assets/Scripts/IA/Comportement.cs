using UnityEngine;
using System.Collections;

abstract public class Comportement{

	public Vector3 destination;
	public Vector3 iapos;
	public int timeBeforeUpdate = 50;


	public abstract void CalculateDestination ();


	public static Comportement getComportement(string type){
		if (type == null || type == "")
			type = "Random";
		string fullType = type + "Comportement";
		System.Type Stype = System.Type.GetType (fullType);
		Comportement c = (Comportement) System.Activator.CreateInstance (Stype);
		return c;
	}


}
