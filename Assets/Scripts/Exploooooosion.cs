using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exploooooosion : MonoBehaviour {


	public ParticleSystem BigBoom;

	// Use this for initialization
	void Start () {
		// plays the explosion audio
		BigBoom.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		

		//ends explosion animation and the explision object is destroyed
		if (BigBoom.IsAlive() == false)
			Destroy(this.gameObject);
	}
}
