using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarateChop : MonoBehaviour {

	public SteamVR_TrackedObject hand;
	private Rigidbody rBody;

	// Use this for initialization
	void Start () {
		rBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		rBody.MovePosition (hand.transform.position);
		rBody.MoveRotation (hand.transform.rotation);
	}
}
