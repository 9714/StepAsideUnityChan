using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void OnBecameInvisible()
	{
		Destroy(this.gameObject);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
