using UnityEngine;
using System.Collections;
using Fungus;

public class BlopComportement : Comportement {

	static public Transform possibleDest;


	public override void CalculateDestination(Transform blop){
		Flowchart flow = GameObject.FindGameObjectWithTag ("Player").GetComponent<capsule>.flow;
		if ((flow.GetIntegerVariable ("Blops1") > 0 && blop.parent != null && blop.parent.gameObject != null && blop.parent.gameObject.name == "Blop1") ||
			(flow.GetIntegerVariable ("Blops2") > 0 && blop.parent != null && blop.parent.gameObject != null && blop.parent.gameObject.name == "Blop2") ||
			(flow.GetIntegerVariable ("Blops3") > 0 && blop.parent != null && blop.parent.gameObject != null && blop.parent.gameObject.name == "Blop3") ) {
			destination = GameObject.FindGameObjectWithTag ("Player").transform.position;
		}
	}
}
